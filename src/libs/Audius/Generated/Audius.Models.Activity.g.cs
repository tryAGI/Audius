
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Activity
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Example: track
        /// </summary>
        /// <example>track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.ActivityItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.ActivityItemType ItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Item { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="itemType">
        /// Example: track
        /// </param>
        /// <param name="item"></param>
        /// <param name="class"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Activity(
            string timestamp,
            global::Audius.ActivityItemType itemType,
            object item,
            string @class)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.ItemType = itemType;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        public Activity()
        {
        }

    }
}