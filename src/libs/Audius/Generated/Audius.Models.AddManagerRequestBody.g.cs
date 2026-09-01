
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddManagerRequestBody
    {
        /// <summary>
        /// The user ID of the user to add as manager
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManagerUserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddManagerRequestBody" /> class.
        /// </summary>
        /// <param name="managerUserId">
        /// The user ID of the user to add as manager
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddManagerRequestBody(
            string managerUserId)
        {
            this.ManagerUserId = managerUserId ?? throw new global::System.ArgumentNullException(nameof(managerUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddManagerRequestBody" /> class.
        /// </summary>
        public AddManagerRequestBody()
        {
        }

    }
}