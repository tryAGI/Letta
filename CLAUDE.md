# CLAUDE.md — Letta SDK

## Overview

C# SDK for the [Letta API](https://docs.letta.com/) (formerly MemGPT) — a stateful AI agent platform with persistent memory, tools, MCP server integration, and multi-agent groups.

- **NuGet Package:** `Letta`
- **Namespace:** `Letta`
- **Client class:** `LettaClient`
- **Target framework:** `net10.0`
- **Auth:** HTTP Bearer token
- **OpenAPI spec:** `https://raw.githubusercontent.com/letta-ai/letta/main/fern/openapi.json` (3.1.0)
- **Generated files:** 6330
- **Operations:** 295 across 233 paths, 341 schemas

## Sub-Clients

| Sub-Client | Description |
|------------|-------------|
| `Agents` | Agent CRUD, messages, memory, passages, tools, files, groups |
| `Archives` | Archive memory stores and passages |
| `Blocks` | Memory block CRUD, identity attachment |
| `Chat` | OpenAI-compatible chat completions |
| `ClientSideAccessTokens` | Client-side access token management |
| `Conversations` | Conversation CRUD, messages, streaming |
| `Embeddings` | Embedding storage metrics |
| `Environments` | Agent environment connections and messaging |
| `Feeds` | Feed/subscription system for agent messaging |
| `Folders` | File folder management, uploads, passages |
| `Health` | Health check endpoint |
| `InternalAgents` | Internal agent operations |
| `InternalBlocks` | Internal block operations |
| `InternalRuns` | Internal run listing |
| `InternalTemplates` | Internal template and deployment management |
| `Jobs` | Background job management |
| `McpServers` | MCP server CRUD, tool listing, execution |
| `MemoryFiles` | Agent memory file system operations |
| `Messages` | Message retrieval, search, batch operations |
| `Metadata` | Server status, user info, balances, telemetry |
| `Models` | LLM model listing |
| `Passages` | Cross-agent passage search |
| `Pipelines` | Data pipeline CRUD and sync |
| `Projects` | Project management |
| `Providers` | LLM provider CRUD and validation |
| `Runs` | Agent run history, steps, metrics, traces |
| `ScheduledMessages` | Scheduled/cron message management |
| `Steps` | Run step details, metrics, traces |
| `Tag` | Tag listing |
| `Templates` | Agent template versioning, forking, rollback |
| `Tools` | Tool CRUD, MCP server/tool management |

## Spec Fixes (`generate.sh`)

The `generate.sh` script applies three fixes via Python before generation:

1. **Remove `text/event-stream`** — AutoSDK does not handle SSE content types; all `text/event-stream` entries are stripped from response content
2. **Fix empty schemas** — Endpoints with empty `application/json` schema `{}` are set to `{ "type": "object" }`
3. **Fix `ModifyApprovalRequest`** — The `required` array is removed because the request body is nullable (`anyOf` with `null`), which conflicts with C# `required` member initialization

## Build & Test

```bash
# Build
dotnet build Letta.slnx

# Run tests (requires LETTA_API_KEY env var)
dotnet test src/tests/IntegrationTests/

# Regenerate from latest spec
cd src/libs/Letta && ./generate.sh
```

## Servers

- **Letta Cloud:** `https://app.letta.com`
- **Self-hosted:** `http://localhost:8283`

## Key Conventions

- Never edit files in `Generated/` — they are overwritten on regeneration
- Hand-written extensions go in partial classes at `src/libs/Letta/` (outside `Generated/`)
- The SDK uses source-generated JSON serialization (no reflection, AOT-compatible)
- All assemblies are strong-named with `src/key.snk`
