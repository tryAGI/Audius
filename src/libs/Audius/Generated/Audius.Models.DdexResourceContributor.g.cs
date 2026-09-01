
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DdexResourceContributor
    {
        /// <summary>
        /// Contributor name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Contributor roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Roles { get; set; }

        /// <summary>
        /// Sequence number for ordering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexResourceContributor" /> class.
        /// </summary>
        /// <param name="name">
        /// Contributor name
        /// </param>
        /// <param name="roles">
        /// Contributor roles
        /// </param>
        /// <param name="sequenceNumber">
        /// Sequence number for ordering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DdexResourceContributor(
            string name,
            global::System.Collections.Generic.IList<string> roles,
            int? sequenceNumber)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Roles = roles ?? throw new global::System.ArgumentNullException(nameof(roles));
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexResourceContributor" /> class.
        /// </summary>
        public DdexResourceContributor()
        {
        }

    }
}