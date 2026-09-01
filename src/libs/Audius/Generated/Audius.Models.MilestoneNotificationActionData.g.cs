#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct MilestoneNotificationActionData : global::System.IEquatable<MilestoneNotificationActionData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.UserMilestoneNotificationActionData? User { get; init; }
#else
        public global::Audius.UserMilestoneNotificationActionData? User { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(User))]
#endif
        public bool IsUser => User != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.UserMilestoneNotificationActionData? value)
        {
            value = User;
            return IsUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.UserMilestoneNotificationActionData PickUser() => IsUser
            ? User!
            : throw new global::System.InvalidOperationException($"Expected union variant 'User' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrackMilestoneNotificationActionData? Track { get; init; }
#else
        public global::Audius.TrackMilestoneNotificationActionData? Track { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Track))]
#endif
        public bool IsTrack => Track != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrackMilestoneNotificationActionData? value)
        {
            value = Track;
            return IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrackMilestoneNotificationActionData PickTrack() => IsTrack
            ? Track!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Track' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.PlaylistMilestoneNotificationActionData? Playlist { get; init; }
#else
        public global::Audius.PlaylistMilestoneNotificationActionData? Playlist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Playlist))]
#endif
        public bool IsPlaylist => Playlist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPlaylist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.PlaylistMilestoneNotificationActionData? value)
        {
            value = Playlist;
            return IsPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.PlaylistMilestoneNotificationActionData PickPlaylist() => IsPlaylist
            ? Playlist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playlist' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MilestoneNotificationActionData(global::Audius.UserMilestoneNotificationActionData value) => new MilestoneNotificationActionData((global::Audius.UserMilestoneNotificationActionData?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.UserMilestoneNotificationActionData?(MilestoneNotificationActionData @this) => @this.User;

        /// <summary>
        ///
        /// </summary>
        public MilestoneNotificationActionData(global::Audius.UserMilestoneNotificationActionData? value)
        {
            User = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MilestoneNotificationActionData FromUser(global::Audius.UserMilestoneNotificationActionData? value) => new MilestoneNotificationActionData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MilestoneNotificationActionData(global::Audius.TrackMilestoneNotificationActionData value) => new MilestoneNotificationActionData((global::Audius.TrackMilestoneNotificationActionData?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrackMilestoneNotificationActionData?(MilestoneNotificationActionData @this) => @this.Track;

        /// <summary>
        ///
        /// </summary>
        public MilestoneNotificationActionData(global::Audius.TrackMilestoneNotificationActionData? value)
        {
            Track = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MilestoneNotificationActionData FromTrack(global::Audius.TrackMilestoneNotificationActionData? value) => new MilestoneNotificationActionData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MilestoneNotificationActionData(global::Audius.PlaylistMilestoneNotificationActionData value) => new MilestoneNotificationActionData((global::Audius.PlaylistMilestoneNotificationActionData?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.PlaylistMilestoneNotificationActionData?(MilestoneNotificationActionData @this) => @this.Playlist;

        /// <summary>
        ///
        /// </summary>
        public MilestoneNotificationActionData(global::Audius.PlaylistMilestoneNotificationActionData? value)
        {
            Playlist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MilestoneNotificationActionData FromPlaylist(global::Audius.PlaylistMilestoneNotificationActionData? value) => new MilestoneNotificationActionData(value);

        /// <summary>
        ///
        /// </summary>
        public MilestoneNotificationActionData(
            global::Audius.UserMilestoneNotificationActionData? user,
            global::Audius.TrackMilestoneNotificationActionData? track,
            global::Audius.PlaylistMilestoneNotificationActionData? playlist
            )
        {
            User = user;
            Track = track;
            Playlist = playlist;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Playlist as object ??
            Track as object ??
            User as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            User?.ToString() ??
            Track?.ToString() ??
            Playlist?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUser && !IsTrack && !IsPlaylist || !IsUser && IsTrack && !IsPlaylist || !IsUser && !IsTrack && IsPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.UserMilestoneNotificationActionData, TResult>? user = null,
            global::System.Func<global::Audius.TrackMilestoneNotificationActionData, TResult>? track = null,
            global::System.Func<global::Audius.PlaylistMilestoneNotificationActionData, TResult>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser && user != null)
            {
                return user(User!);
            }
            else if (IsTrack && track != null)
            {
                return track(Track!);
            }
            else if (IsPlaylist && playlist != null)
            {
                return playlist(Playlist!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.UserMilestoneNotificationActionData>? user = null,

            global::System.Action<global::Audius.TrackMilestoneNotificationActionData>? track = null,

            global::System.Action<global::Audius.PlaylistMilestoneNotificationActionData>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
            else if (IsPlaylist)
            {
                playlist?.Invoke(Playlist!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.UserMilestoneNotificationActionData>? user = null,
            global::System.Action<global::Audius.TrackMilestoneNotificationActionData>? track = null,
            global::System.Action<global::Audius.PlaylistMilestoneNotificationActionData>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUser)
            {
                user?.Invoke(User!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
            else if (IsPlaylist)
            {
                playlist?.Invoke(Playlist!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                User,
                typeof(global::Audius.UserMilestoneNotificationActionData),
                Track,
                typeof(global::Audius.TrackMilestoneNotificationActionData),
                Playlist,
                typeof(global::Audius.PlaylistMilestoneNotificationActionData),
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
        public bool Equals(MilestoneNotificationActionData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.UserMilestoneNotificationActionData?>.Default.Equals(User, other.User) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrackMilestoneNotificationActionData?>.Default.Equals(Track, other.Track) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.PlaylistMilestoneNotificationActionData?>.Default.Equals(Playlist, other.Playlist)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MilestoneNotificationActionData obj1, MilestoneNotificationActionData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MilestoneNotificationActionData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MilestoneNotificationActionData obj1, MilestoneNotificationActionData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MilestoneNotificationActionData o && Equals(o);
        }
    }
}
