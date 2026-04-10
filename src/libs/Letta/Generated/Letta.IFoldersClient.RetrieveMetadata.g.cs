#nullable enable

namespace Letta
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Retrieve Metadata<br/>
        /// Get aggregated metadata for all folders in an organization.<br/>
        /// Returns structured metadata including:<br/>
        /// - Total number of folders<br/>
        /// - Total number of files across all folders<br/>
        /// - Total size of all files<br/>
        /// - Per-source breakdown with file details (file_name, file_size per file) if include_detailed_per_source_metadata is True
        /// </summary>
        /// <param name="includeDetailedPerSourceMetadata">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.OrganizationSourcesStats> RetrieveMetadataAsync(
            bool? includeDetailedPerSourceMetadata = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}