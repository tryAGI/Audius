#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CreateNotificationActionData : global::System.IEquatable<CreateNotificationActionData>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CreatePlaylistNotificationActionData? Playlist { get; init; }
#else
        public global::Audius.CreatePlaylistNotificationActionData? Playlist { get; }
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
            out global::Audius.CreatePlaylistNotificationActionData? value)
        {
            value = Playlist;
            return IsPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CreatePlaylistNotificationActionData PickPlaylist() => IsPlaylist
            ? Playlist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playlist' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CreateTrackNotificationActionData? Track { get; init; }
#else
        public global::Audius.CreateTrackNotificationActionData? Track { get; }
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
            out global::Audius.CreateTrackNotificationActionData? value)
        {
            value = Track;
            return IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CreateTrackNotificationActionData PickTrack() => IsTrack
            ? Track!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Track' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateNotificationActionData(global::Audius.CreatePlaylistNotificationActionData value) => new CreateNotificationActionData((global::Audius.CreatePlaylistNotificationActionData?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CreatePlaylistNotificationActionData?(CreateNotificationActionData @this) => @this.Playlist;

        /// <summary>
        ///
        /// </summary>
        public CreateNotificationActionData(global::Audius.CreatePlaylistNotificationActionData? value)
        {
            Playlist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateNotificationActionData FromPlaylist(global::Audius.CreatePlaylistNotificationActionData? value) => new CreateNotificationActionData(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CreateNotificationActionData(global::Audius.CreateTrackNotificationActionData value) => new CreateNotificationActionData((global::Audius.CreateTrackNotificationActionData?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CreateTrackNotificationActionData?(CreateNotificationActionData @this) => @this.Track;

        /// <summary>
        ///
        /// </summary>
        public CreateNotificationActionData(global::Audius.CreateTrackNotificationActionData? value)
        {
            Track = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CreateNotificationActionData FromTrack(global::Audius.CreateTrackNotificationActionData? value) => new CreateNotificationActionData(value);

        /// <summary>
        ///
        /// </summary>
        public CreateNotificationActionData(
            global::Audius.CreatePlaylistNotificationActionData? playlist,
            global::Audius.CreateTrackNotificationActionData? track
            )
        {
            Playlist = playlist;
            Track = track;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Track as object ??
            Playlist as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Playlist?.ToString() ??
            Track?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPlaylist && !IsTrack || !IsPlaylist && IsTrack;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.CreatePlaylistNotificationActionData, TResult>? playlist = null,
            global::System.Func<global::Audius.CreateTrackNotificationActionData, TResult>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylist && playlist != null)
            {
                return playlist(Playlist!);
            }
            else if (IsTrack && track != null)
            {
                return track(Track!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.CreatePlaylistNotificationActionData>? playlist = null,

            global::System.Action<global::Audius.CreateTrackNotificationActionData>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylist)
            {
                playlist?.Invoke(Playlist!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.CreatePlaylistNotificationActionData>? playlist = null,
            global::System.Action<global::Audius.CreateTrackNotificationActionData>? track = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlaylist)
            {
                playlist?.Invoke(Playlist!);
            }
            else if (IsTrack)
            {
                track?.Invoke(Track!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Playlist,
                typeof(global::Audius.CreatePlaylistNotificationActionData),
                Track,
                typeof(global::Audius.CreateTrackNotificationActionData),
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
        public bool Equals(CreateNotificationActionData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.CreatePlaylistNotificationActionData?>.Default.Equals(Playlist, other.Playlist) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CreateTrackNotificationActionData?>.Default.Equals(Track, other.Track)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CreateNotificationActionData obj1, CreateNotificationActionData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateNotificationActionData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CreateNotificationActionData obj1, CreateNotificationActionData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateNotificationActionData o && Equals(o);
        }
    }
}
