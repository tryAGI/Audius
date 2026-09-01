#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtendedAccessGate : global::System.IEquatable<ExtendedAccessGate>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TipGate? Tip { get; init; }
#else
        public global::Audius.TipGate? Tip { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tip))]
#endif
        public bool IsTip => Tip != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTip(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TipGate? value)
        {
            value = Tip;
            return IsTip;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TipGate PickTip() => IsTip
            ? Tip!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tip' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FollowGate? Follow { get; init; }
#else
        public global::Audius.FollowGate? Follow { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Follow))]
#endif
        public bool IsFollow => Follow != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFollow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FollowGate? value)
        {
            value = Follow;
            return IsFollow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FollowGate PickFollow() => IsFollow
            ? Follow!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Follow' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ExtendedPurchaseGate? Purchase { get; init; }
#else
        public global::Audius.ExtendedPurchaseGate? Purchase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Purchase))]
#endif
        public bool IsPurchase => Purchase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPurchase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ExtendedPurchaseGate? value)
        {
            value = Purchase;
            return IsPurchase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ExtendedPurchaseGate PickPurchase() => IsPurchase
            ? Purchase!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Purchase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TokenGate? Token { get; init; }
#else
        public global::Audius.TokenGate? Token { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Token))]
#endif
        public bool IsToken => Token != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToken(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TokenGate? value)
        {
            value = Token;
            return IsToken;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TokenGate PickToken() => IsToken
            ? Token!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Token' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ExtendedAccessGate(global::Audius.TipGate value) => new ExtendedAccessGate((global::Audius.TipGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TipGate?(ExtendedAccessGate @this) => @this.Tip;

        /// <summary>
        ///
        /// </summary>
        public ExtendedAccessGate(global::Audius.TipGate? value)
        {
            Tip = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ExtendedAccessGate FromTip(global::Audius.TipGate? value) => new ExtendedAccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ExtendedAccessGate(global::Audius.FollowGate value) => new ExtendedAccessGate((global::Audius.FollowGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FollowGate?(ExtendedAccessGate @this) => @this.Follow;

        /// <summary>
        ///
        /// </summary>
        public ExtendedAccessGate(global::Audius.FollowGate? value)
        {
            Follow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ExtendedAccessGate FromFollow(global::Audius.FollowGate? value) => new ExtendedAccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ExtendedAccessGate(global::Audius.ExtendedPurchaseGate value) => new ExtendedAccessGate((global::Audius.ExtendedPurchaseGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ExtendedPurchaseGate?(ExtendedAccessGate @this) => @this.Purchase;

        /// <summary>
        ///
        /// </summary>
        public ExtendedAccessGate(global::Audius.ExtendedPurchaseGate? value)
        {
            Purchase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ExtendedAccessGate FromPurchase(global::Audius.ExtendedPurchaseGate? value) => new ExtendedAccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ExtendedAccessGate(global::Audius.TokenGate value) => new ExtendedAccessGate((global::Audius.TokenGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TokenGate?(ExtendedAccessGate @this) => @this.Token;

        /// <summary>
        ///
        /// </summary>
        public ExtendedAccessGate(global::Audius.TokenGate? value)
        {
            Token = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ExtendedAccessGate FromToken(global::Audius.TokenGate? value) => new ExtendedAccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public ExtendedAccessGate(
            global::Audius.TipGate? tip,
            global::Audius.FollowGate? follow,
            global::Audius.ExtendedPurchaseGate? purchase,
            global::Audius.TokenGate? token
            )
        {
            Tip = tip;
            Follow = follow;
            Purchase = purchase;
            Token = token;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Token as object ??
            Purchase as object ??
            Follow as object ??
            Tip as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Tip?.ToString() ??
            Follow?.ToString() ??
            Purchase?.ToString() ??
            Token?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTip && !IsFollow && !IsPurchase && !IsToken || !IsTip && IsFollow && !IsPurchase && !IsToken || !IsTip && !IsFollow && IsPurchase && !IsToken || !IsTip && !IsFollow && !IsPurchase && IsToken;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.TipGate, TResult>? tip = null,
            global::System.Func<global::Audius.FollowGate, TResult>? follow = null,
            global::System.Func<global::Audius.ExtendedPurchaseGate, TResult>? purchase = null,
            global::System.Func<global::Audius.TokenGate, TResult>? token = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTip && tip != null)
            {
                return tip(Tip!);
            }
            else if (IsFollow && follow != null)
            {
                return follow(Follow!);
            }
            else if (IsPurchase && purchase != null)
            {
                return purchase(Purchase!);
            }
            else if (IsToken && token != null)
            {
                return token(Token!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.TipGate>? tip = null,

            global::System.Action<global::Audius.FollowGate>? follow = null,

            global::System.Action<global::Audius.ExtendedPurchaseGate>? purchase = null,

            global::System.Action<global::Audius.TokenGate>? token = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTip)
            {
                tip?.Invoke(Tip!);
            }
            else if (IsFollow)
            {
                follow?.Invoke(Follow!);
            }
            else if (IsPurchase)
            {
                purchase?.Invoke(Purchase!);
            }
            else if (IsToken)
            {
                token?.Invoke(Token!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.TipGate>? tip = null,
            global::System.Action<global::Audius.FollowGate>? follow = null,
            global::System.Action<global::Audius.ExtendedPurchaseGate>? purchase = null,
            global::System.Action<global::Audius.TokenGate>? token = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTip)
            {
                tip?.Invoke(Tip!);
            }
            else if (IsFollow)
            {
                follow?.Invoke(Follow!);
            }
            else if (IsPurchase)
            {
                purchase?.Invoke(Purchase!);
            }
            else if (IsToken)
            {
                token?.Invoke(Token!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tip,
                typeof(global::Audius.TipGate),
                Follow,
                typeof(global::Audius.FollowGate),
                Purchase,
                typeof(global::Audius.ExtendedPurchaseGate),
                Token,
                typeof(global::Audius.TokenGate),
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
        public bool Equals(ExtendedAccessGate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.TipGate?>.Default.Equals(Tip, other.Tip) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FollowGate?>.Default.Equals(Follow, other.Follow) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ExtendedPurchaseGate?>.Default.Equals(Purchase, other.Purchase) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TokenGate?>.Default.Equals(Token, other.Token)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ExtendedAccessGate obj1, ExtendedAccessGate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExtendedAccessGate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtendedAccessGate obj1, ExtendedAccessGate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtendedAccessGate o && Equals(o);
        }
    }
}
