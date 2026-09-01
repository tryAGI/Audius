
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Attestation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Attestation1 { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Attestation" /> class.
        /// </summary>
        /// <param name="ownerWallet"></param>
        /// <param name="attestation1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Attestation(
            string ownerWallet,
            string attestation1)
        {
            this.OwnerWallet = ownerWallet ?? throw new global::System.ArgumentNullException(nameof(ownerWallet));
            this.Attestation1 = attestation1 ?? throw new global::System.ArgumentNullException(nameof(attestation1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attestation" /> class.
        /// </summary>
        public Attestation()
        {
        }

    }
}