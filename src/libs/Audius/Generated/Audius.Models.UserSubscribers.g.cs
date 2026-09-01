
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserSubscribers
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_ids")]
        public global::System.Collections.Generic.IList<string>? SubscriberIds { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscribers" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="subscriberIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserSubscribers(
            string userId,
            global::System.Collections.Generic.IList<string>? subscriberIds)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.SubscriberIds = subscriberIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscribers" /> class.
        /// </summary>
        public UserSubscribers()
        {
        }

    }
}