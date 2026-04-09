
#nullable enable

namespace Letta
{
    public partial class AgentsClient
    {


        private static readonly global::Letta.EndPointSecurityRequirement s_AgentsSearchDeployedAgentsSecurityRequirement0 =
            new global::Letta.EndPointSecurityRequirement
            {
                Authorizations = new global::Letta.EndPointAuthorizationRequirement[]
                {                    new global::Letta.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Letta.EndPointSecurityRequirement[] s_AgentsSearchDeployedAgentsSecurityRequirements =
            new global::Letta.EndPointSecurityRequirement[]
            {                s_AgentsSearchDeployedAgentsSecurityRequirement0,
            };
        partial void PrepareAgentsSearchDeployedAgentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Letta.AgentsSearchDeployedAgentsRequest request);
        partial void PrepareAgentsSearchDeployedAgentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Letta.AgentsSearchDeployedAgentsRequest request);
        partial void ProcessAgentsSearchDeployedAgentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsSearchDeployedAgentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Letta.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(

            global::Letta.AgentsSearchDeployedAgentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentsSearchDeployedAgentsArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Letta.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AgentsSearchDeployedAgentsSecurityRequirements,
                operationName: "AgentsSearchDeployedAgentsAsync");

            var __pathBuilder = new global::Letta.PathBuilder(
                path: "/v1/agents/search",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsSearchDeployedAgentsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsSearchDeployedAgentsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAgentsSearchDeployedAgentsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Letta.AgentsSearchDeployedAgentsResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Letta.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Letta.AgentsSearchDeployedAgentsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Letta.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="sortBy"></param>
        /// <param name="ascending"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Letta.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::Letta.AgentsSearchDeployedAgentsRequestCombinator? combinator = default,
            double? limit = default,
            string? after = default,
            global::Letta.AgentsSearchDeployedAgentsRequestSortBy? sortBy = default,
            bool? ascending = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Letta.AgentsSearchDeployedAgentsRequest
            {
                Search = search,
                ProjectId = projectId,
                Combinator = combinator,
                Limit = limit,
                After = after,
                SortBy = sortBy,
                Ascending = ascending,
            };

            return await AgentsSearchDeployedAgentsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}