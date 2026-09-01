
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaveNotificationActionData
    {
        /// <summary>
        /// Example: track
        /// </summary>
        /// <example>track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.SaveNotificationActionDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.SaveNotificationActionDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SaveItemId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveNotificationActionData" /> class.
        /// </summary>
        /// <param name="type">
        /// Example: track
        /// </param>
        /// <param name="userId"></param>
        /// <param name="saveItemId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveNotificationActionData(
            global::Audius.SaveNotificationActionDataType type,
            string userId,
            string saveItemId)
        {
            this.Type = type;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.SaveItemId = saveItemId ?? throw new global::System.ArgumentNullException(nameof(saveItemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveNotificationActionData" /> class.
        /// </summary>
        public SaveNotificationActionData()
        {
        }

    }
}