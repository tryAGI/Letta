dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/letta-ai/letta/main/fern/openapi.json

# Fix spec using Python:
# 1. Remove text/event-stream content type from all responses (AutoSDK doesn't handle SSE)
# 2. For endpoints with empty application/json schema {}, set schema to { "type": "object" }
python3 - <<'PYEOF'
import json

with open("openapi.yaml") as f:
    spec = json.load(f)

# Fix ModifyApprovalRequest: remove 'required' array since the request body is optional
if "ModifyApprovalRequest" in spec.get("components", {}).get("schemas", {}):
    schema = spec["components"]["schemas"]["ModifyApprovalRequest"]
    if "required" in schema:
        del schema["required"]

for path, methods in spec.get("paths", {}).items():
    for method, details in methods.items():
        if not isinstance(details, dict):
            continue
        responses = details.get("responses", {})
        for code, resp in responses.items():
            if not isinstance(resp, dict) or "content" not in resp:
                continue
            content = resp["content"]
            # Remove text/event-stream
            if "text/event-stream" in content:
                del content["text/event-stream"]
            # Fix empty application/json schemas
            if "application/json" in content:
                schema = content["application/json"].get("schema")
                if schema == {} or schema is None:
                    content["application/json"]["schema"] = {"type": "object"}

with open("openapi.yaml", "w") as f:
    json.dump(spec, f, indent=2)
PYEOF

autosdk generate openapi.yaml \
  --namespace Letta \
  --clientClassName LettaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
