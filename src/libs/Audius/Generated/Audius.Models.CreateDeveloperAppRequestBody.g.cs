
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDeveloperAppRequestBody
    {
        /// <summary>
        /// Developer app name<br/>
        /// Example: My API Key
        /// </summary>
        /// <example>My API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// App description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// App logo/image URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Pre-registered OAuth redirect/callback URIs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeveloperAppRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// Developer app name<br/>
        /// Example: My API Key
        /// </param>
        /// <param name="description">
        /// App description
        /// </param>
        /// <param name="imageUrl">
        /// App logo/image URL
        /// </param>
        /// <param name="redirectUris">
        /// Pre-registered OAuth redirect/callback URIs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDeveloperAppRequestBody(
            string name,
            string? description,
            string? imageUrl,
            global::System.Collections.Generic.IList<string>? redirectUris)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.RedirectUris = redirectUris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeveloperAppRequestBody" /> class.
        /// </summary>
        public CreateDeveloperAppRequestBody()
        {
        }

    }
}