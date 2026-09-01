
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TastemakerNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tastemaker_item_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TastemakerItemOwnerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tastemaker_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TastemakerItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tastemaker_item_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TastemakerItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tastemaker_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TastemakerUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TastemakerNotificationActionData" /> class.
        /// </summary>
        /// <param name="tastemakerItemOwnerId"></param>
        /// <param name="tastemakerItemId"></param>
        /// <param name="action"></param>
        /// <param name="tastemakerItemType"></param>
        /// <param name="tastemakerUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TastemakerNotificationActionData(
            string tastemakerItemOwnerId,
            string tastemakerItemId,
            string action,
            string tastemakerItemType,
            string tastemakerUserId)
        {
            this.TastemakerItemOwnerId = tastemakerItemOwnerId ?? throw new global::System.ArgumentNullException(nameof(tastemakerItemOwnerId));
            this.TastemakerItemId = tastemakerItemId ?? throw new global::System.ArgumentNullException(nameof(tastemakerItemId));
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.TastemakerItemType = tastemakerItemType ?? throw new global::System.ArgumentNullException(nameof(tastemakerItemType));
            this.TastemakerUserId = tastemakerUserId ?? throw new global::System.ArgumentNullException(nameof(tastemakerUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TastemakerNotificationActionData" /> class.
        /// </summary>
        public TastemakerNotificationActionData()
        {
        }

    }
}