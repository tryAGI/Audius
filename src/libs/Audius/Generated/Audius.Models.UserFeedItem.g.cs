#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UserFeedItem : global::System.IEquatable<UserFeedItem>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrackFeedItem? Track { get; init; }
#else
        public global::Audius.TrackFeedItem? Track { get; }
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
            out global::Audius.TrackFeedItem? value)
        {
            value = Track;
            return IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrackFeedItem PickTrack() => IsTrack
            ? Track!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Track' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.PlaylistFeedItem? Playlist { get; init; }
#else
        public global::Audius.PlaylistFeedItem? Playlist { get; }
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
            out global::Audius.PlaylistFeedItem? value)
        {
            value = Playlist;
            return IsPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.PlaylistFeedItem PickPlaylist() => IsPlaylist
            ? Playlist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playlist' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserFeedItem(global::Audius.TrackFeedItem value) => new UserFeedItem((global::Audius.TrackFeedItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrackFeedItem?(UserFeedItem @this) => @this.Track;

        /// <summary>
        ///
        /// </summary>
        public UserFeedItem(global::Audius.TrackFeedItem? value)
        {
            Track = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserFeedItem FromTrack(global::Audius.TrackFeedItem? value) => new UserFeedItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserFeedItem(global::Audius.PlaylistFeedItem value) => new UserFeedItem((global::Audius.PlaylistFeedItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.PlaylistFeedItem?(UserFeedItem @this) => @this.Playlist;

        /// <summary>
        ///
        /// </summary>
        public UserFeedItem(global::Audius.PlaylistFeedItem? value)
        {
            Playlist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserFeedItem FromPlaylist(global::Audius.PlaylistFeedItem? value) => new UserFeedItem(value);

        /// <summary>
        ///
        /// </summary>
        public UserFeedItem(
            global::Audius.TrackFeedItem? track,
            global::Audius.PlaylistFeedItem? playlist
            )
        {
            Track = track;
            Playlist = playlist;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Playlist as object ??
            Track as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Track?.ToString() ??
            Playlist?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTrack && !IsPlaylist || !IsTrack && IsPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.TrackFeedItem, TResult>? track = null,
            global::System.Func<global::Audius.PlaylistFeedItem, TResult>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack && track != null)
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
            global::System.Action<global::Audius.TrackFeedItem>? track = null,

            global::System.Action<global::Audius.PlaylistFeedItem>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack)
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
            global::System.Action<global::Audius.TrackFeedItem>? track = null,
            global::System.Action<global::Audius.PlaylistFeedItem>? playlist = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTrack)
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
                Track,
                typeof(global::Audius.TrackFeedItem),
                Playlist,
                typeof(global::Audius.PlaylistFeedItem),
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
        public bool Equals(UserFeedItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrackFeedItem?>.Default.Equals(Track, other.Track) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.PlaylistFeedItem?>.Default.Equals(Playlist, other.Playlist)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UserFeedItem obj1, UserFeedItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserFeedItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UserFeedItem obj1, UserFeedItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserFeedItem o && Equals(o);
        }
    }
}
