
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagedUser
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User User { get; set; }

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
        /// Initializes a new instance of the <see cref="ManagedUser" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="grant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedUser(
            global::Audius.User user,
            global::Audius.Grant grant)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Grant = grant ?? throw new global::System.ArgumentNullException(nameof(grant));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedUser" /> class.
        /// </summary>
        public ManagedUser()
        {
        }

    }
}