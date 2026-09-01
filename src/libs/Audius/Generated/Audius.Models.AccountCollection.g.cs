
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountCollection
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_album")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlbum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permalink { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.AccountCollectionUser User { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isAlbum"></param>
        /// <param name="name"></param>
        /// <param name="permalink"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountCollection(
            string id,
            bool isAlbum,
            string name,
            string permalink,
            global::Audius.AccountCollectionUser user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsAlbum = isAlbum;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permalink = permalink ?? throw new global::System.ArgumentNullException(nameof(permalink));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollection" /> class.
        /// </summary>
        public AccountCollection()
        {
        }

    }
}