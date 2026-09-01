#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TrackActivity : global::System.IEquatable<TrackActivity>
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
        public global::Audius.TrackActivityVariant2? TrackActivityVariant2 { get; init; }
#else
        public global::Audius.TrackActivityVariant2? TrackActivityVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackActivityVariant2))]
#endif
        public bool IsTrackActivityVariant2 => TrackActivityVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrackActivityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrackActivityVariant2? value)
        {
            value = TrackActivityVariant2;
            return IsTrackActivityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrackActivityVariant2 PickTrackActivityVariant2() => IsTrackActivityVariant2
            ? TrackActivityVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackActivityVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrackActivity(global::Audius.Activity value) => new TrackActivity((global::Audius.Activity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.Activity?(TrackActivity @this) => @this.Activity;

        /// <summary>
        ///
        /// </summary>
        public TrackActivity(global::Audius.Activity? value)
        {
            Activity = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrackActivity FromActivity(global::Audius.Activity? value) => new TrackActivity(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrackActivity(global::Audius.TrackActivityVariant2 value) => new TrackActivity((global::Audius.TrackActivityVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrackActivityVariant2?(TrackActivity @this) => @this.TrackActivityVariant2;

        /// <summary>
        ///
        /// </summary>
        public TrackActivity(global::Audius.TrackActivityVariant2? value)
        {
            TrackActivityVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrackActivity FromTrackActivityVariant2(global::Audius.TrackActivityVariant2? value) => new TrackActivity(value);

        /// <summary>
        ///
        /// </summary>
        public TrackActivity(
            global::Audius.Activity? activity,
            global::Audius.TrackActivityVariant2? trackActivityVariant2
            )
        {
            Activity = activity;
            TrackActivityVariant2 = trackActivityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TrackActivityVariant2 as object ??
            Activity as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Activity?.ToString() ??
            TrackActivityVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActivity && IsTrackActivityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.Activity, TResult>? activity = null,
            global::System.Func<global::Audius.TrackActivityVariant2, TResult>? trackActivityVariant2 = null,
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
            else if (IsTrackActivityVariant2 && trackActivityVariant2 != null)
            {
                return trackActivityVariant2(TrackActivityVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.Activity>? activity = null,

            global::System.Action<global::Audius.TrackActivityVariant2>? trackActivityVariant2 = null,
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
            else if (IsTrackActivityVariant2)
            {
                trackActivityVariant2?.Invoke(TrackActivityVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.Activity>? activity = null,
            global::System.Action<global::Audius.TrackActivityVariant2>? trackActivityVariant2 = null,
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
            else if (IsTrackActivityVariant2)
            {
                trackActivityVariant2?.Invoke(TrackActivityVariant2!);
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
                TrackActivityVariant2,
                typeof(global::Audius.TrackActivityVariant2),
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
        public bool Equals(TrackActivity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.Activity?>.Default.Equals(Activity, other.Activity) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrackActivityVariant2?>.Default.Equals(TrackActivityVariant2, other.TrackActivityVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TrackActivity obj1, TrackActivity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackActivity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TrackActivity obj1, TrackActivity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackActivity o && Equals(o);
        }
    }
}
