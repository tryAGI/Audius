#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CollectionActivityWithoutTracks : global::System.IEquatable<CollectionActivityWithoutTracks>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.Activity? Activity { get; init; }
#else
        public global::Audius.Activity? Activity { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Activity))]
#endif
        public bool IsActivity => Activity != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickActivity(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.Activity? value)
        {
            value = Activity;
            return IsActivity;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.Activity PickActivity() => IsActivity
            ? Activity!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Activity' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CollectionActivityWithoutTracksVariant2? CollectionActivityWithoutTracksVariant2 { get; init; }
#else
        public global::Audius.CollectionActivityWithoutTracksVariant2? CollectionActivityWithoutTracksVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CollectionActivityWithoutTracksVariant2))]
#endif
        public bool IsCollectionActivityWithoutTracksVariant2 => CollectionActivityWithoutTracksVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCollectionActivityWithoutTracksVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CollectionActivityWithoutTracksVariant2? value)
        {
            value = CollectionActivityWithoutTracksVariant2;
            return IsCollectionActivityWithoutTracksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CollectionActivityWithoutTracksVariant2 PickCollectionActivityWithoutTracksVariant2() => IsCollectionActivityWithoutTracksVariant2
            ? CollectionActivityWithoutTracksVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CollectionActivityWithoutTracksVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CollectionActivityWithoutTracks(global::Audius.Activity value) => new CollectionActivityWithoutTracks((global::Audius.Activity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.Activity?(CollectionActivityWithoutTracks @this) => @this.Activity;

        /// <summary>
        ///
        /// </summary>
        public CollectionActivityWithoutTracks(global::Audius.Activity? value)
        {
            Activity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CollectionActivityWithoutTracks FromActivity(global::Audius.Activity? value) => new CollectionActivityWithoutTracks(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CollectionActivityWithoutTracks(global::Audius.CollectionActivityWithoutTracksVariant2 value) => new CollectionActivityWithoutTracks((global::Audius.CollectionActivityWithoutTracksVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CollectionActivityWithoutTracksVariant2?(CollectionActivityWithoutTracks @this) => @this.CollectionActivityWithoutTracksVariant2;

        /// <summary>
        ///
        /// </summary>
        public CollectionActivityWithoutTracks(global::Audius.CollectionActivityWithoutTracksVariant2? value)
        {
            CollectionActivityWithoutTracksVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CollectionActivityWithoutTracks FromCollectionActivityWithoutTracksVariant2(global::Audius.CollectionActivityWithoutTracksVariant2? value) => new CollectionActivityWithoutTracks(value);

        /// <summary>
        ///
        /// </summary>
        public CollectionActivityWithoutTracks(
            global::Audius.Activity? activity,
            global::Audius.CollectionActivityWithoutTracksVariant2? collectionActivityWithoutTracksVariant2
            )
        {
            Activity = activity;
            CollectionActivityWithoutTracksVariant2 = collectionActivityWithoutTracksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CollectionActivityWithoutTracksVariant2 as object ??
            Activity as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Activity?.ToString() ??
            CollectionActivityWithoutTracksVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActivity && IsCollectionActivityWithoutTracksVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.Activity, TResult>? activity = null,
            global::System.Func<global::Audius.CollectionActivityWithoutTracksVariant2, TResult>? collectionActivityWithoutTracksVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActivity && activity != null)
            {
                return activity(Activity!);
            }
            else if (IsCollectionActivityWithoutTracksVariant2 && collectionActivityWithoutTracksVariant2 != null)
            {
                return collectionActivityWithoutTracksVariant2(CollectionActivityWithoutTracksVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.Activity>? activity = null,

            global::System.Action<global::Audius.CollectionActivityWithoutTracksVariant2>? collectionActivityWithoutTracksVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActivity)
            {
                activity?.Invoke(Activity!);
            }
            else if (IsCollectionActivityWithoutTracksVariant2)
            {
                collectionActivityWithoutTracksVariant2?.Invoke(CollectionActivityWithoutTracksVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.Activity>? activity = null,
            global::System.Action<global::Audius.CollectionActivityWithoutTracksVariant2>? collectionActivityWithoutTracksVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActivity)
            {
                activity?.Invoke(Activity!);
            }
            else if (IsCollectionActivityWithoutTracksVariant2)
            {
                collectionActivityWithoutTracksVariant2?.Invoke(CollectionActivityWithoutTracksVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Activity,
                typeof(global::Audius.Activity),
                CollectionActivityWithoutTracksVariant2,
                typeof(global::Audius.CollectionActivityWithoutTracksVariant2),
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
        public bool Equals(CollectionActivityWithoutTracks other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.Activity?>.Default.Equals(Activity, other.Activity) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CollectionActivityWithoutTracksVariant2?>.Default.Equals(CollectionActivityWithoutTracksVariant2, other.CollectionActivityWithoutTracksVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CollectionActivityWithoutTracks obj1, CollectionActivityWithoutTracks obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionActivityWithoutTracks>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CollectionActivityWithoutTracks obj1, CollectionActivityWithoutTracks obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionActivityWithoutTracks o && Equals(o);
        }
    }
}
