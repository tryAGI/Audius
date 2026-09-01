#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AccessGate : global::System.IEquatable<AccessGate>
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
        public global::Audius.PurchaseGate? Purchase { get; init; }
#else
        public global::Audius.PurchaseGate? Purchase { get; }
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
            out global::Audius.PurchaseGate? value)
        {
            value = Purchase;
            return IsPurchase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.PurchaseGate PickPurchase() => IsPurchase
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
        public static implicit operator AccessGate(global::Audius.TipGate value) => new AccessGate((global::Audius.TipGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TipGate?(AccessGate @this) => @this.Tip;

        /// <summary>
        ///
        /// </summary>
        public AccessGate(global::Audius.TipGate? value)
        {
            Tip = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessGate FromTip(global::Audius.TipGate? value) => new AccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccessGate(global::Audius.FollowGate value) => new AccessGate((global::Audius.FollowGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FollowGate?(AccessGate @this) => @this.Follow;

        /// <summary>
        ///
        /// </summary>
        public AccessGate(global::Audius.FollowGate? value)
        {
            Follow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessGate FromFollow(global::Audius.FollowGate? value) => new AccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccessGate(global::Audius.PurchaseGate value) => new AccessGate((global::Audius.PurchaseGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.PurchaseGate?(AccessGate @this) => @this.Purchase;

        /// <summary>
        ///
        /// </summary>
        public AccessGate(global::Audius.PurchaseGate? value)
        {
            Purchase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessGate FromPurchase(global::Audius.PurchaseGate? value) => new AccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccessGate(global::Audius.TokenGate value) => new AccessGate((global::Audius.TokenGate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TokenGate?(AccessGate @this) => @this.Token;

        /// <summary>
        ///
        /// </summary>
        public AccessGate(global::Audius.TokenGate? value)
        {
            Token = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccessGate FromToken(global::Audius.TokenGate? value) => new AccessGate(value);

        /// <summary>
        ///
        /// </summary>
        public AccessGate(
            global::Audius.TipGate? tip,
            global::Audius.FollowGate? follow,
            global::Audius.PurchaseGate? purchase,
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
            global::System.Func<global::Audius.PurchaseGate, TResult>? purchase = null,
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

            global::System.Action<global::Audius.PurchaseGate>? purchase = null,

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
            global::System.Action<global::Audius.PurchaseGate>? purchase = null,
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
                typeof(global::Audius.PurchaseGate),
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
        public bool Equals(AccessGate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.TipGate?>.Default.Equals(Tip, other.Tip) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FollowGate?>.Default.Equals(Follow, other.Follow) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.PurchaseGate?>.Default.Equals(Purchase, other.Purchase) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TokenGate?>.Default.Equals(Token, other.Token)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AccessGate obj1, AccessGate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccessGate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AccessGate obj1, AccessGate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccessGate o && Equals(o);
        }
    }
}
