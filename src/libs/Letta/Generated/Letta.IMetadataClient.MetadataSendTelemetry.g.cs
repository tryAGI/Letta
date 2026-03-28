#nullable enable

namespace Letta
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Send telemetry event<br/>
        /// Send telemetry events for usage tracking and analysis.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MetadataSendTelemetryResponse> MetadataSendTelemetryAsync(

            global::Letta.MetadataSendTelemetryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send telemetry event<br/>
        /// Send telemetry events for usage tracking and analysis.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MetadataSendTelemetryResponse> MetadataSendTelemetryAsync(
            global::System.Collections.Generic.IList<global::Letta.EventsItem> events,
            global::Letta.MetadataSendTelemetryRequestService service = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}