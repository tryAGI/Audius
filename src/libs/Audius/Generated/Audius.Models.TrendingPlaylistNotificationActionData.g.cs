
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrendingPlaylistNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistId { get; set; }

        /// <summary>
        /// Example: week
        /// </summary>
        /// <example>week</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.TrendingPlaylistNotificationActionDataTimeRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.TrendingPlaylistNotificationActionDataTimeRange TimeRange { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingPlaylistNotificationActionData" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="genre"></param>
        /// <param name="playlistId"></param>
        /// <param name="timeRange">
        /// Example: week
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrendingPlaylistNotificationActionData(
            int rank,
            string genre,
            string playlistId,
            global::Audius.TrendingPlaylistNotificationActionDataTimeRange timeRange)
        {
            this.Rank = rank;
            this.Genre = genre ?? throw new global::System.ArgumentNullException(nameof(genre));
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingPlaylistNotificationActionData" /> class.
        /// </summary>
        public TrendingPlaylistNotificationActionData()
        {
        }

    }
}