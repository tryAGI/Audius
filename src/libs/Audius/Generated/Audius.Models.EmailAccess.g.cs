
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmailAccess
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_owner_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmailOwnerUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receiving_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReceivingUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantor_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int GrantorUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_initial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInitial { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAccess" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emailOwnerUserId"></param>
        /// <param name="receivingUserId"></param>
        /// <param name="grantorUserId"></param>
        /// <param name="encryptedKey"></param>
        /// <param name="isInitial"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailAccess(
            int id,
            int emailOwnerUserId,
            int receivingUserId,
            int grantorUserId,
            string encryptedKey,
            bool isInitial,
            string createdAt,
            string updatedAt)
        {
            this.Id = id;
            this.EmailOwnerUserId = emailOwnerUserId;
            this.ReceivingUserId = receivingUserId;
            this.GrantorUserId = grantorUserId;
            this.EncryptedKey = encryptedKey ?? throw new global::System.ArgumentNullException(nameof(encryptedKey));
            this.IsInitial = isInitial;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAccess" /> class.
        /// </summary>
        public EmailAccess()
        {
        }

    }
}