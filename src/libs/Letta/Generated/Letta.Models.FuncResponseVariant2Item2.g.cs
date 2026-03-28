#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FuncResponseVariant2Item2 : global::System.IEquatable<FuncResponseVariant2Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? Type { get; }

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
        public static implicit operator FuncResponseVariant2Item2(global::Letta.TextContent value) => new FuncResponseVariant2Item2((global::Letta.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TextContent?(FuncResponseVariant2Item2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public FuncResponseVariant2Item2(global::Letta.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FuncResponseVariant2Item2(global::Letta.ImageContent value) => new FuncResponseVariant2Item2((global::Letta.ImageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ImageContent?(FuncResponseVariant2Item2 @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public FuncResponseVariant2Item2(global::Letta.ImageContent? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FuncResponseVariant2Item2(
            global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType? type,
            global::Letta.TextContent? text,
            global::Letta.ImageContent? image
            )
        {
            Type = type;

            Text = text;
            Image = image;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage || !IsText && IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.TextContent?, TResult>? text = null,
            global::System.Func<global::Letta.ImageContent?, TResult>? image = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.TextContent?>? text = null,
            global::System.Action<global::Letta.ImageContent?>? image = null,
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
        public bool Equals(FuncResponseVariant2Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.TextContent?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ImageContent?>.Default.Equals(Image, other.Image) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FuncResponseVariant2Item2 obj1, FuncResponseVariant2Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FuncResponseVariant2Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FuncResponseVariant2Item2 obj1, FuncResponseVariant2Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FuncResponseVariant2Item2 o && Equals(o);
        }
    }
}
