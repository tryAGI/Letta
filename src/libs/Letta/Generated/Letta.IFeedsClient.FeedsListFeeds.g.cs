#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feeds<br/>
        /// List all feeds with optional filters and pagination
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsListFeedsResponse> FeedsListFeedsAsync(
            string? projectId = default,
            string? name = default,
            string? limit = default,
            global::Letta.OneOf<string, double?>? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}