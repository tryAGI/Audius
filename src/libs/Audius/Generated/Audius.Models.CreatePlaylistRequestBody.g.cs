
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePlaylistRequestBody
    {
        /// <summary>
        /// Optional playlist ID (will be generated if not provided)<br/>
        /// Example: x5pJ3Az
        /// </summary>
        /// <example>x5pJ3Az</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        public string? PlaylistId { get; set; }

        /// <summary>
        /// Playlist or album name<br/>
        /// Example: My New Playlist
        /// </summary>
        /// <example>My New Playlist</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistName { get; set; }

        /// <summary>
        /// Playlist description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the playlist is private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_private")]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// Whether this is an album
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_album")]
        public bool? IsAlbum { get; set; }

        /// <summary>
        /// Music genre
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.GenreJsonConverter))]
        public global::Audius.Genre? Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.MoodJsonConverter))]
        public global::Audius.Mood? Mood { get; set; }

        /// <summary>
        /// Comma-separated tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// License type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// Universal Product Code (for albums)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upc")]
        public string? Upc { get; set; }

        /// <summary>
        /// Release date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// CID for the playlist cover art
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_image_sizes_multihash")]
        public string? PlaylistImageSizesMultihash { get; set; }

        /// <summary>
        /// Array of tracks in the playlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_contents")]
        public global::System.Collections.Generic.IList<global::Audius.PlaylistAddedTimestamp>? PlaylistContents { get; set; }

        /// <summary>
        /// Whether streaming is restricted behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stream_gated")]
        public bool? IsStreamGated { get; set; }

        /// <summary>
        /// Whether the playlist/album is a scheduled release
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scheduled_release")]
        public bool? IsScheduledRelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.AccessGateJsonConverter))]
        public global::Audius.AccessGate? StreamConditions { get; set; }

        /// <summary>
        /// DDEX application identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_app")]
        public string? DdexApp { get; set; }

        /// <summary>
        /// DDEX release identifiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_release_ids")]
        public global::System.Collections.Generic.Dictionary<string, string>? DdexReleaseIds { get; set; }

        /// <summary>
        /// DDEX resource contributors / artists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        public global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? Artists { get; set; }

        /// <summary>
        /// DDEX copyright line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright_line")]
        public global::Audius.DdexCopyright? CopyrightLine { get; set; }

        /// <summary>
        /// DDEX producer copyright line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_copyright_line")]
        public global::Audius.DdexCopyright? ProducerCopyrightLine { get; set; }

        /// <summary>
        /// Parental warning type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parental_warning_type")]
        public string? ParentalWarningType { get; set; }

        /// <summary>
        /// Whether the image is autogenerated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_autogenerated")]
        public bool? IsImageAutogenerated { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlaylistRequestBody" /> class.
        /// </summary>
        /// <param name="playlistName">
        /// Playlist or album name<br/>
        /// Example: My New Playlist
        /// </param>
        /// <param name="playlistId">
        /// Optional playlist ID (will be generated if not provided)<br/>
        /// Example: x5pJ3Az
        /// </param>
        /// <param name="description">
        /// Playlist description
        /// </param>
        /// <param name="isPrivate">
        /// Whether the playlist is private
        /// </param>
        /// <param name="isAlbum">
        /// Whether this is an album
        /// </param>
        /// <param name="genre">
        /// Music genre
        /// </param>
        /// <param name="mood"></param>
        /// <param name="tags">
        /// Comma-separated tags
        /// </param>
        /// <param name="license">
        /// License type
        /// </param>
        /// <param name="upc">
        /// Universal Product Code (for albums)
        /// </param>
        /// <param name="releaseDate">
        /// Release date
        /// </param>
        /// <param name="playlistImageSizesMultihash">
        /// CID for the playlist cover art
        /// </param>
        /// <param name="playlistContents">
        /// Array of tracks in the playlist
        /// </param>
        /// <param name="isStreamGated">
        /// Whether streaming is restricted behind an access gate
        /// </param>
        /// <param name="isScheduledRelease">
        /// Whether the playlist/album is a scheduled release
        /// </param>
        /// <param name="streamConditions"></param>
        /// <param name="ddexApp">
        /// DDEX application identifier
        /// </param>
        /// <param name="ddexReleaseIds">
        /// DDEX release identifiers
        /// </param>
        /// <param name="artists">
        /// DDEX resource contributors / artists
        /// </param>
        /// <param name="copyrightLine">
        /// DDEX copyright line
        /// </param>
        /// <param name="producerCopyrightLine">
        /// DDEX producer copyright line
        /// </param>
        /// <param name="parentalWarningType">
        /// Parental warning type
        /// </param>
        /// <param name="isImageAutogenerated">
        /// Whether the image is autogenerated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlaylistRequestBody(
            string playlistName,
            string? playlistId,
            string? description,
            bool? isPrivate,
            bool? isAlbum,
            global::Audius.Genre? genre,
            global::Audius.Mood? mood,
            string? tags,
            string? license,
            string? upc,
            global::System.DateTime? releaseDate,
            string? playlistImageSizesMultihash,
            global::System.Collections.Generic.IList<global::Audius.PlaylistAddedTimestamp>? playlistContents,
            bool? isStreamGated,
            bool? isScheduledRelease,
            global::Audius.AccessGate? streamConditions,
            string? ddexApp,
            global::System.Collections.Generic.Dictionary<string, string>? ddexReleaseIds,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? artists,
            global::Audius.DdexCopyright? copyrightLine,
            global::Audius.DdexCopyright? producerCopyrightLine,
            string? parentalWarningType,
            bool? isImageAutogenerated)
        {
            this.PlaylistId = playlistId;
            this.PlaylistName = playlistName ?? throw new global::System.ArgumentNullException(nameof(playlistName));
            this.Description = description;
            this.IsPrivate = isPrivate;
            this.IsAlbum = isAlbum;
            this.Genre = genre;
            this.Mood = mood;
            this.Tags = tags;
            this.License = license;
            this.Upc = upc;
            this.ReleaseDate = releaseDate;
            this.PlaylistImageSizesMultihash = playlistImageSizesMultihash;
            this.PlaylistContents = playlistContents;
            this.IsStreamGated = isStreamGated;
            this.IsScheduledRelease = isScheduledRelease;
            this.StreamConditions = streamConditions;
            this.DdexApp = ddexApp;
            this.DdexReleaseIds = ddexReleaseIds;
            this.Artists = artists;
            this.CopyrightLine = copyrightLine;
            this.ProducerCopyrightLine = producerCopyrightLine;
            this.ParentalWarningType = parentalWarningType;
            this.IsImageAutogenerated = isImageAutogenerated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlaylistRequestBody" /> class.
        /// </summary>
        public CreatePlaylistRequestBody()
        {
        }

    }
}