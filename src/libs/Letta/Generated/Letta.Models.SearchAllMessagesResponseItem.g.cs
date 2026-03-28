#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchAllMessagesResponseItem : global::System.IEquatable<SearchAllMessagesResponseItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// System message list result with agent context.<br/>
        /// Shape is identical to UpdateSystemMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.SystemMessageListResult? SystemMessage { get; init; }
#else
        public global::Letta.SystemMessageListResult? SystemMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessage))]
#endif
        public bool IsSystemMessage => SystemMessage != null;

        /// <summary>
        /// User message list result with agent context.<br/>
        /// Shape is identical to UpdateUserMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.UserMessageListResult? UserMessage { get; init; }
#else
        public global::Letta.UserMessageListResult? UserMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        /// Reasoning message list result with agent context.<br/>
        /// Shape is identical to UpdateReasoningMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ReasoningMessageListResult? ReasoningMessage { get; init; }
#else
        public global::Letta.ReasoningMessageListResult? ReasoningMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningMessage))]
#endif
        public bool IsReasoningMessage => ReasoningMessage != null;

        /// <summary>
        /// Assistant message list result with agent context.<br/>
        /// Shape is identical to UpdateAssistantMessage but includes the owning agent_id and message id.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.AssistantMessageListResult? AssistantMessage { get; init; }
#else
        public global::Letta.AssistantMessageListResult? AssistantMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantMessage))]
#endif
        public bool IsAssistantMessage => AssistantMessage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::Letta.SystemMessageListResult value) => new SearchAllMessagesResponseItem((global::Letta.SystemMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SystemMessageListResult?(SearchAllMessagesResponseItem @this) => @this.SystemMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::Letta.SystemMessageListResult? value)
        {
            SystemMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::Letta.UserMessageListResult value) => new SearchAllMessagesResponseItem((global::Letta.UserMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.UserMessageListResult?(SearchAllMessagesResponseItem @this) => @this.UserMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::Letta.UserMessageListResult? value)
        {
            UserMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::Letta.ReasoningMessageListResult value) => new SearchAllMessagesResponseItem((global::Letta.ReasoningMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ReasoningMessageListResult?(SearchAllMessagesResponseItem @this) => @this.ReasoningMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::Letta.ReasoningMessageListResult? value)
        {
            ReasoningMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchAllMessagesResponseItem(global::Letta.AssistantMessageListResult value) => new SearchAllMessagesResponseItem((global::Letta.AssistantMessageListResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.AssistantMessageListResult?(SearchAllMessagesResponseItem @this) => @this.AssistantMessage;

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(global::Letta.AssistantMessageListResult? value)
        {
            AssistantMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchAllMessagesResponseItem(
            global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType? messageType,
            global::Letta.SystemMessageListResult? systemMessage,
            global::Letta.UserMessageListResult? userMessage,
            global::Letta.ReasoningMessageListResult? reasoningMessage,
            global::Letta.AssistantMessageListResult? assistantMessage
            )
        {
            MessageType = messageType;

            SystemMessage = systemMessage;
            UserMessage = userMessage;
            ReasoningMessage = reasoningMessage;
            AssistantMessage = assistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantMessage as object ??
            ReasoningMessage as object ??
            UserMessage as object ??
            SystemMessage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SystemMessage?.ToString() ??
            UserMessage?.ToString() ??
            ReasoningMessage?.ToString() ??
            AssistantMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemMessage && !IsUserMessage && !IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && IsUserMessage && !IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && !IsUserMessage && IsReasoningMessage && !IsAssistantMessage || !IsSystemMessage && !IsUserMessage && !IsReasoningMessage && IsAssistantMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.SystemMessageListResult?, TResult>? systemMessage = null,
            global::System.Func<global::Letta.UserMessageListResult?, TResult>? userMessage = null,
            global::System.Func<global::Letta.ReasoningMessageListResult?, TResult>? reasoningMessage = null,
            global::System.Func<global::Letta.AssistantMessageListResult?, TResult>? assistantMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage && systemMessage != null)
            {
                return systemMessage(SystemMessage!);
            }
            else if (IsUserMessage && userMessage != null)
            {
                return userMessage(UserMessage!);
            }
            else if (IsReasoningMessage && reasoningMessage != null)
            {
                return reasoningMessage(ReasoningMessage!);
            }
            else if (IsAssistantMessage && assistantMessage != null)
            {
                return assistantMessage(AssistantMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.SystemMessageListResult?>? systemMessage = null,
            global::System.Action<global::Letta.UserMessageListResult?>? userMessage = null,
            global::System.Action<global::Letta.ReasoningMessageListResult?>? reasoningMessage = null,
            global::System.Action<global::Letta.AssistantMessageListResult?>? assistantMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemMessage)
            {
                systemMessage?.Invoke(SystemMessage!);
            }
            else if (IsUserMessage)
            {
                userMessage?.Invoke(UserMessage!);
            }
            else if (IsReasoningMessage)
            {
                reasoningMessage?.Invoke(ReasoningMessage!);
            }
            else if (IsAssistantMessage)
            {
                assistantMessage?.Invoke(AssistantMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemMessage,
                typeof(global::Letta.SystemMessageListResult),
                UserMessage,
                typeof(global::Letta.UserMessageListResult),
                ReasoningMessage,
                typeof(global::Letta.ReasoningMessageListResult),
                AssistantMessage,
                typeof(global::Letta.AssistantMessageListResult),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SearchAllMessagesResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.SystemMessageListResult?>.Default.Equals(SystemMessage, other.SystemMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.UserMessageListResult?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ReasoningMessageListResult?>.Default.Equals(ReasoningMessage, other.ReasoningMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.AssistantMessageListResult?>.Default.Equals(AssistantMessage, other.AssistantMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchAllMessagesResponseItem obj1, SearchAllMessagesResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchAllMessagesResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchAllMessagesResponseItem obj1, SearchAllMessagesResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchAllMessagesResponseItem o && Equals(o);
        }
    }
}
