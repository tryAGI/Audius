
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountCollectionUser
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
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deactivated")]
        public bool? IsDeactivated { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="handle"></param>
        /// <param name="isDeactivated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountCollectionUser(
            string id,
            string handle,
            bool? isDeactivated)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.IsDeactivated = isDeactivated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCollectionUser" /> class.
        /// </summary>
        public AccountCollectionUser()
        {
        }

    }
}