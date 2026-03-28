#nullable enable

namespace Letta
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Retrieve Message<br/>
        /// Retrieve a message by ID.
        /// </summary>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.LettaMessageUnion>> RetrieveMessageAsync(
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}