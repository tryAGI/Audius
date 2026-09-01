
#nullable enable

namespace Audius
{
    /// <summary>
    /// User events for tracking referrals and mobile users
    /// </summary>
    public sealed partial class CreateUserRequestBodyEvents
    {
        /// <summary>
        /// Hash ID of the user who referred this user<br/>
        /// Example: k9Xm5Pz
        /// </summary>
        /// <example>k9Xm5Pz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("referrer")]
        public string? Referrer { get; set; }

        /// <summary>
        /// Whether the user is on mobile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_mobile_user")]
        public bool? IsMobileUser { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBodyEvents" /> class.
        /// </summary>
        /// <param name="referrer">
        /// Hash ID of the user who referred this user<br/>
        /// Example: k9Xm5Pz
        /// </param>
        /// <param name="isMobileUser">
        /// Whether the user is on mobile
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUserRequestBodyEvents(
            string? referrer,
            bool? isMobileUser)
        {
            this.Referrer = referrer;
            this.IsMobileUser = isMobileUser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequestBodyEvents" /> class.
        /// </summary>
        public CreateUserRequestBodyEvents()
        {
        }

    }
}