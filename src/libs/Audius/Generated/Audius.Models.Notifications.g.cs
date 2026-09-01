
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Notifications
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        public global::System.Collections.Generic.IList<global::Audius.Notification>? Notifications1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unread_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnreadCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications" /> class.
        /// </summary>
        /// <param name="unreadCount"></param>
        /// <param name="notifications1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Notifications(
            int unreadCount,
            global::System.Collections.Generic.IList<global::Audius.Notification>? notifications1)
        {
            this.Notifications1 = notifications1;
            this.UnreadCount = unreadCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications" /> class.
        /// </summary>
        public Notifications()
        {
        }

    }
}