
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserManager
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User Manager { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.Grant Grant { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager" /> class.
        /// </summary>
        /// <param name="manager"></param>
        /// <param name="grant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserManager(
            global::Audius.User manager,
            global::Audius.Grant grant)
        {
            this.Manager = manager ?? throw new global::System.ArgumentNullException(nameof(manager));
            this.Grant = grant ?? throw new global::System.ArgumentNullException(nameof(grant));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager" /> class.
        /// </summary>
        public UserManager()
        {
        }

    }
}