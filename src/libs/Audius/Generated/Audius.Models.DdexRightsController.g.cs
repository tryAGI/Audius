
#nullable enable

namespace Audius
{
    /// <summary>
    /// DDEX rights controller
    /// </summary>
    public sealed partial class DdexRightsController
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rights_share_unknown")]
        public string? RightsShareUnknown { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexRightsController" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="roles"></param>
        /// <param name="rightsShareUnknown">
        /// Optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DdexRightsController(
            string name,
            global::System.Collections.Generic.IList<string> roles,
            string? rightsShareUnknown)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
            this.RightsShareUnknown = rightsShareUnknown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexRightsController" /> class.
        /// </summary>
        public DdexRightsController()
        {
        }

    }
}