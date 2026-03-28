#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant1Item : global::System.IEquatable<ContentVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.MessageContentVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TextContent? Text { get; init; }
#else
        public global::Letta.TextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ImageContent? Image { get; init; }
#else
        public global::Letta.ImageContent? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ToolCallContent? ToolCall { get; init; }
#else
        public global::Letta.ToolCallContent? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ToolReturnContent? ToolReturn { get; init; }
#else
        public global::Letta.ToolReturnContent? ToolReturn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolReturn))]
#endif
        public bool IsToolReturn => ToolReturn != null;

        /// <summary>
        /// Sent via the Anthropic Messages API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ReasoningContent? OmittedReasoning1 { get; init; }
#else
        public global::Letta.ReasoningContent? OmittedReasoning1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OmittedReasoning1))]
#endif
        public bool IsOmittedReasoning1 => OmittedReasoning1 != null;

        /// <summary>
        /// Sent via the Anthropic Messages API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.RedactedReasoningContent? RedactedReasoning { get; init; }
#else
        public global::Letta.RedactedReasoningContent? RedactedReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedReasoning))]
#endif
        public bool IsRedactedReasoning => RedactedReasoning != null;

        /// <summary>
        /// A placeholder for reasoning content we know is present, but isn't returned by the provider (e.g. OpenAI GPT-5 on ChatCompletions)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.OmittedReasoningContent? OmittedReasoning2 { get; init; }
#else
        public global::Letta.OmittedReasoningContent? OmittedReasoning2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OmittedReasoning2))]
#endif
        public bool IsOmittedReasoning2 => OmittedReasoning2 != null;

        /// <summary>
        /// The style of reasoning content returned by the OpenAI Responses API
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.SummarizedReasoningContent? SummarizedReasoning { get; init; }
#else
        public global::Letta.SummarizedReasoningContent? SummarizedReasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SummarizedReasoning))]
#endif
        public bool IsSummarizedReasoning => SummarizedReasoning != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.TextContent value) => new ContentVariant1Item((global::Letta.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TextContent?(ContentVariant1Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.ImageContent value) => new ContentVariant1Item((global::Letta.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ImageContent?(ContentVariant1Item @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.ToolCallContent value) => new ContentVariant1Item((global::Letta.ToolCallContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ToolCallContent?(ContentVariant1Item @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.ToolCallContent? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.ToolReturnContent value) => new ContentVariant1Item((global::Letta.ToolReturnContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ToolReturnContent?(ContentVariant1Item @this) => @this.ToolReturn;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.ToolReturnContent? value)
        {
            ToolReturn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.ReasoningContent value) => new ContentVariant1Item((global::Letta.ReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ReasoningContent?(ContentVariant1Item @this) => @this.OmittedReasoning1;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.ReasoningContent? value)
        {
            OmittedReasoning1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.RedactedReasoningContent value) => new ContentVariant1Item((global::Letta.RedactedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RedactedReasoningContent?(ContentVariant1Item @this) => @this.RedactedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.RedactedReasoningContent? value)
        {
            RedactedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.OmittedReasoningContent value) => new ContentVariant1Item((global::Letta.OmittedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.OmittedReasoningContent?(ContentVariant1Item @this) => @this.OmittedReasoning2;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.OmittedReasoningContent? value)
        {
            OmittedReasoning2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant1Item(global::Letta.SummarizedReasoningContent value) => new ContentVariant1Item((global::Letta.SummarizedReasoningContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SummarizedReasoningContent?(ContentVariant1Item @this) => @this.SummarizedReasoning;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(global::Letta.SummarizedReasoningContent? value)
        {
            SummarizedReasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant1Item(
            global::Letta.MessageContentVariant1ItemDiscriminatorType? type,
            global::Letta.TextContent? text,
            global::Letta.ImageContent? image,
            global::Letta.ToolCallContent? toolCall,
            global::Letta.ToolReturnContent? toolReturn,
            global::Letta.ReasoningContent? omittedReasoning1,
            global::Letta.RedactedReasoningContent? redactedReasoning,
            global::Letta.OmittedReasoningContent? omittedReasoning2,
            global::Letta.SummarizedReasoningContent? summarizedReasoning
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolCall = toolCall;
            ToolReturn = toolReturn;
            OmittedReasoning1 = omittedReasoning1;
            RedactedReasoning = redactedReasoning;
            OmittedReasoning2 = omittedReasoning2;
            SummarizedReasoning = summarizedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SummarizedReasoning as object ??
            OmittedReasoning2 as object ??
            RedactedReasoning as object ??
            OmittedReasoning1 as object ??
            ToolReturn as object ??
            ToolCall as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            ToolCall?.ToString() ??
            ToolReturn?.ToString() ??
            OmittedReasoning1?.ToString() ??
            RedactedReasoning?.ToString() ??
            OmittedReasoning2?.ToString() ??
            SummarizedReasoning?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && IsRedactedReasoning && !IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && IsOmittedReasoning2 && !IsSummarizedReasoning || !IsText && !IsImage && !IsToolCall && !IsToolReturn && !IsOmittedReasoning1 && !IsRedactedReasoning && !IsOmittedReasoning2 && IsSummarizedReasoning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.TextContent?, TResult>? text = null,
            global::System.Func<global::Letta.ImageContent?, TResult>? image = null,
            global::System.Func<global::Letta.ToolCallContent?, TResult>? toolCall = null,
            global::System.Func<global::Letta.ToolReturnContent?, TResult>? toolReturn = null,
            global::System.Func<global::Letta.ReasoningContent?, TResult>? omittedReasoning1 = null,
            global::System.Func<global::Letta.RedactedReasoningContent?, TResult>? redactedReasoning = null,
            global::System.Func<global::Letta.OmittedReasoningContent?, TResult>? omittedReasoning2 = null,
            global::System.Func<global::Letta.SummarizedReasoningContent?, TResult>? summarizedReasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolReturn && toolReturn != null)
            {
                return toolReturn(ToolReturn!);
            }
            else if (IsOmittedReasoning1 && omittedReasoning1 != null)
            {
                return omittedReasoning1(OmittedReasoning1!);
            }
            else if (IsRedactedReasoning && redactedReasoning != null)
            {
                return redactedReasoning(RedactedReasoning!);
            }
            else if (IsOmittedReasoning2 && omittedReasoning2 != null)
            {
                return omittedReasoning2(OmittedReasoning2!);
            }
            else if (IsSummarizedReasoning && summarizedReasoning != null)
            {
                return summarizedReasoning(SummarizedReasoning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.TextContent?>? text = null,
            global::System.Action<global::Letta.ImageContent?>? image = null,
            global::System.Action<global::Letta.ToolCallContent?>? toolCall = null,
            global::System.Action<global::Letta.ToolReturnContent?>? toolReturn = null,
            global::System.Action<global::Letta.ReasoningContent?>? omittedReasoning1 = null,
            global::System.Action<global::Letta.RedactedReasoningContent?>? redactedReasoning = null,
            global::System.Action<global::Letta.OmittedReasoningContent?>? omittedReasoning2 = null,
            global::System.Action<global::Letta.SummarizedReasoningContent?>? summarizedReasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolReturn)
            {
                toolReturn?.Invoke(ToolReturn!);
            }
            else if (IsOmittedReasoning1)
            {
                omittedReasoning1?.Invoke(OmittedReasoning1!);
            }
            else if (IsRedactedReasoning)
            {
                redactedReasoning?.Invoke(RedactedReasoning!);
            }
            else if (IsOmittedReasoning2)
            {
                omittedReasoning2?.Invoke(OmittedReasoning2!);
            }
            else if (IsSummarizedReasoning)
            {
                summarizedReasoning?.Invoke(SummarizedReasoning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Letta.TextContent),
                Image,
                typeof(global::Letta.ImageContent),
                ToolCall,
                typeof(global::Letta.ToolCallContent),
                ToolReturn,
                typeof(global::Letta.ToolReturnContent),
                OmittedReasoning1,
                typeof(global::Letta.ReasoningContent),
                RedactedReasoning,
                typeof(global::Letta.RedactedReasoningContent),
                OmittedReasoning2,
                typeof(global::Letta.OmittedReasoningContent),
                SummarizedReasoning,
                typeof(global::Letta.SummarizedReasoningContent),
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
        public bool Equals(ContentVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ImageContent?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ToolCallContent?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ToolReturnContent?>.Default.Equals(ToolReturn, other.ToolReturn) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ReasoningContent?>.Default.Equals(OmittedReasoning1, other.OmittedReasoning1) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.RedactedReasoningContent?>.Default.Equals(RedactedReasoning, other.RedactedReasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.OmittedReasoningContent?>.Default.Equals(OmittedReasoning2, other.OmittedReasoning2) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SummarizedReasoningContent?>.Default.Equals(SummarizedReasoning, other.SummarizedReasoning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant1Item obj1, ContentVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant1Item obj1, ContentVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant1Item o && Equals(o);
        }
    }
}
