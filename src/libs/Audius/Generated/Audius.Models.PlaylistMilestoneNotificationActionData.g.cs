
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistMilestoneNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_album")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlbum { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistMilestoneNotificationActionData" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="threshold"></param>
        /// <param name="playlistId"></param>
        /// <param name="isAlbum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistMilestoneNotificationActionData(
            string type,
            int threshold,
            string playlistId,
            bool isAlbum)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Threshold = threshold;
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
            this.IsAlbum = isAlbum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistMilestoneNotificationActionData" /> class.
        /// </summary>
        public PlaylistMilestoneNotificationActionData()
        {
        }

    }
}