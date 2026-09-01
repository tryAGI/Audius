
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoinsVolumeLeadersResponseDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Volume { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Audius.User? User { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinsVolumeLeadersResponseDataItem" /> class.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="volume"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinsVolumeLeadersResponseDataItem(
            string address,
            double volume,
            global::Audius.User? user)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Volume = volume;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinsVolumeLeadersResponseDataItem" /> class.
        /// </summary>
        public CoinsVolumeLeadersResponseDataItem()
        {
        }

    }
}