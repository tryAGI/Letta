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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.TextContent? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.TextContent PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.ImageContent? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.ImageContent PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

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
        public bool TryPickToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.ToolCallContent? value)
        {
            value = ToolCall;
            return IsToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.ToolCallContent PickToolCall() => ToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolCall' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickToolReturn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.ToolReturnContent? value)
        {
            value = ToolReturn;
            return IsToolReturn;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.ToolReturnContent PickToolReturn() => ToolReturn is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolReturn' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickOmittedReasoning1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.ReasoningContent? value)
        {
            value = OmittedReasoning1;
            return IsOmittedReasoning1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.ReasoningContent PickOmittedReasoning1() => OmittedReasoning1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OmittedReasoning1' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickRedactedReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.RedactedReasoningContent? value)
        {
            value = RedactedReasoning;
            return IsRedactedReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.RedactedReasoningContent PickRedactedReasoning() => RedactedReasoning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedReasoning' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickOmittedReasoning2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.OmittedReasoningContent? value)
        {
            value = OmittedReasoning2;
            return IsOmittedReasoning2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.OmittedReasoningContent PickOmittedReasoning2() => OmittedReasoning2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OmittedReasoning2' but the value was {ToString()}.");

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
        public bool TryPickSummarizedReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.SummarizedReasoningContent? value)
        {
            value = SummarizedReasoning;
            return IsSummarizedReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.SummarizedReasoningContent PickSummarizedReasoning() => SummarizedReasoning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SummarizedReasoning' but the value was {ToString()}.");
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
        public static ContentVariant1Item FromText(global::Letta.TextContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromImage(global::Letta.ImageContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromToolCall(global::Letta.ToolCallContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromToolReturn(global::Letta.ToolReturnContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromOmittedReasoning1(global::Letta.ReasoningContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromRedactedReasoning(global::Letta.RedactedReasoningContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromOmittedReasoning2(global::Letta.OmittedReasoningContent? value) => new ContentVariant1Item(value);

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
        public static ContentVariant1Item FromSummarizedReasoning(global::Letta.SummarizedReasoningContent? value) => new ContentVariant1Item(value);

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
            global::System.Func<global::Letta.TextContent, TResult>? text = null,
            global::System.Func<global::Letta.ImageContent, TResult>? image = null,
            global::System.Func<global::Letta.ToolCallContent, TResult>? toolCall = null,
            global::System.Func<global::Letta.ToolReturnContent, TResult>? toolReturn = null,
            global::System.Func<global::Letta.ReasoningContent, TResult>? omittedReasoning1 = null,
            global::System.Func<global::Letta.RedactedReasoningContent, TResult>? redactedReasoning = null,
            global::System.Func<global::Letta.OmittedReasoningContent, TResult>? omittedReasoning2 = null,
            global::System.Func<global::Letta.SummarizedReasoningContent, TResult>? summarizedReasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Image is { } __value1 && image != null)
            {
                return image(__value1);
            }
            else if (ToolCall is { } __value2 && toolCall != null)
            {
                return toolCall(__value2);
            }
            else if (ToolReturn is { } __value3 && toolReturn != null)
            {
                return toolReturn(__value3);
            }
            else if (OmittedReasoning1 is { } __value4 && omittedReasoning1 != null)
            {
                return omittedReasoning1(__value4);
            }
            else if (RedactedReasoning is { } __value5 && redactedReasoning != null)
            {
                return redactedReasoning(__value5);
            }
            else if (OmittedReasoning2 is { } __value6 && omittedReasoning2 != null)
            {
                return omittedReasoning2(__value6);
            }
            else if (SummarizedReasoning is { } __value7 && summarizedReasoning != null)
            {
                return summarizedReasoning(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.TextContent>? text = null,

            global::System.Action<global::Letta.ImageContent>? image = null,

            global::System.Action<global::Letta.ToolCallContent>? toolCall = null,

            global::System.Action<global::Letta.ToolReturnContent>? toolReturn = null,

            global::System.Action<global::Letta.ReasoningContent>? omittedReasoning1 = null,

            global::System.Action<global::Letta.RedactedReasoningContent>? redactedReasoning = null,

            global::System.Action<global::Letta.OmittedReasoningContent>? omittedReasoning2 = null,

            global::System.Action<global::Letta.SummarizedReasoningContent>? summarizedReasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (ToolCall is { } __value2)
            {
                toolCall?.Invoke(__value2);
            }
            else if (ToolReturn is { } __value3)
            {
                toolReturn?.Invoke(__value3);
            }
            else if (OmittedReasoning1 is { } __value4)
            {
                omittedReasoning1?.Invoke(__value4);
            }
            else if (RedactedReasoning is { } __value5)
            {
                redactedReasoning?.Invoke(__value5);
            }
            else if (OmittedReasoning2 is { } __value6)
            {
                omittedReasoning2?.Invoke(__value6);
            }
            else if (SummarizedReasoning is { } __value7)
            {
                summarizedReasoning?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Letta.TextContent>? text = null,
            global::System.Action<global::Letta.ImageContent>? image = null,
            global::System.Action<global::Letta.ToolCallContent>? toolCall = null,
            global::System.Action<global::Letta.ToolReturnContent>? toolReturn = null,
            global::System.Action<global::Letta.ReasoningContent>? omittedReasoning1 = null,
            global::System.Action<global::Letta.RedactedReasoningContent>? redactedReasoning = null,
            global::System.Action<global::Letta.OmittedReasoningContent>? omittedReasoning2 = null,
            global::System.Action<global::Letta.SummarizedReasoningContent>? summarizedReasoning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Image is { } __value1)
            {
                image?.Invoke(__value1);
            }
            else if (ToolCall is { } __value2)
            {
                toolCall?.Invoke(__value2);
            }
            else if (ToolReturn is { } __value3)
            {
                toolReturn?.Invoke(__value3);
            }
            else if (OmittedReasoning1 is { } __value4)
            {
                omittedReasoning1?.Invoke(__value4);
            }
            else if (RedactedReasoning is { } __value5)
            {
                redactedReasoning?.Invoke(__value5);
            }
            else if (OmittedReasoning2 is { } __value6)
            {
                omittedReasoning2?.Invoke(__value6);
            }
            else if (SummarizedReasoning is { } __value7)
            {
                summarizedReasoning?.Invoke(__value7);
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
