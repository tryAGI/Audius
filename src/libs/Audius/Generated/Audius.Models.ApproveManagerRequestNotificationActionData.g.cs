
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApproveManagerRequestNotificationActionData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("grantee_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GranteeUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantee_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GranteeAddress { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveManagerRequestNotificationActionData" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="granteeUserId"></param>
        /// <param name="granteeAddress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApproveManagerRequestNotificationActionData(
            string userId,
            string granteeUserId,
            string granteeAddress)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.GranteeUserId = granteeUserId ?? throw new global::System.ArgumentNullException(nameof(granteeUserId));
            this.GranteeAddress = granteeAddress ?? throw new global::System.ArgumentNullException(nameof(granteeAddress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveManagerRequestNotificationActionData" /> class.
        /// </summary>
        public ApproveManagerRequestNotificationActionData()
        {
        }

    }
}