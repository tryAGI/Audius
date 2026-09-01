
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DecodedUserToken
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public global::Audius.ProfilePicture? ProfilePicture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Iat { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodedUserToken" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="userId"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="handle"></param>
        /// <param name="verified"></param>
        /// <param name="sub"></param>
        /// <param name="iat"></param>
        /// <param name="profilePicture"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecodedUserToken(
            string apiKey,
            string userId,
            string email,
            string name,
            string handle,
            bool verified,
            string sub,
            string iat,
            global::Audius.ProfilePicture? profilePicture)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Verified = verified;
            this.ProfilePicture = profilePicture;
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
            this.Iat = iat ?? throw new global::System.ArgumentNullException(nameof(iat));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecodedUserToken" /> class.
        /// </summary>
        public DecodedUserToken()
        {
        }

    }
}