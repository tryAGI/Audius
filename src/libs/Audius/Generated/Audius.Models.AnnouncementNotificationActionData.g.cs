
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnouncementNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PushBody { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LongDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Route { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_campaign_id")]
        public string? NotificationCampaignId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnouncementNotificationActionData" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="pushBody"></param>
        /// <param name="shortDescription"></param>
        /// <param name="longDescription"></param>
        /// <param name="route"></param>
        /// <param name="notificationCampaignId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnouncementNotificationActionData(
            string title,
            string pushBody,
            string shortDescription,
            string longDescription,
            string route,
            string? notificationCampaignId)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.PushBody = pushBody ?? throw new global::System.ArgumentNullException(nameof(pushBody));
            this.ShortDescription = shortDescription ?? throw new global::System.ArgumentNullException(nameof(shortDescription));
            this.LongDescription = longDescription ?? throw new global::System.ArgumentNullException(nameof(longDescription));
            this.Route = route ?? throw new global::System.ArgumentNullException(nameof(route));
            this.NotificationCampaignId = notificationCampaignId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnouncementNotificationActionData" /> class.
        /// </summary>
        public AnnouncementNotificationActionData()
        {
        }

    }
}