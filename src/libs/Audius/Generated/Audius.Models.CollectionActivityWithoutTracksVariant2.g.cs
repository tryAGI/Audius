
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CollectionActivityWithoutTracksVariant2
    {
        /// <summary>
        /// Example: playlist
        /// </summary>
        /// <example>playlist</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.CollectionActivityWithoutTracksVariant2ItemTypeJsonConverter))]
        public global::Audius.CollectionActivityWithoutTracksVariant2ItemType ItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.PlaylistWithoutTracks Item { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionActivityWithoutTracksVariant2" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="itemType">
        /// Example: playlist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionActivityWithoutTracksVariant2(
            global::Audius.PlaylistWithoutTracks item,
            global::Audius.CollectionActivityWithoutTracksVariant2ItemType itemType)
        {
            this.ItemType = itemType;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionActivityWithoutTracksVariant2" /> class.
        /// </summary>
        public CollectionActivityWithoutTracksVariant2()
        {
        }

    }
}