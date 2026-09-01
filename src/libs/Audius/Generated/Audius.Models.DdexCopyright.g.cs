
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DdexCopyright
    {
        /// <summary>
        /// Copyright year (4 characters)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Year { get; set; }

        /// <summary>
        /// Copyright text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexCopyright" /> class.
        /// </summary>
        /// <param name="year">
        /// Copyright year (4 characters)
        /// </param>
        /// <param name="text">
        /// Copyright text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DdexCopyright(
            string year,
            string text)
        {
            this.Year = year ?? throw new global::System.ArgumentNullException(nameof(year));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DdexCopyright" /> class.
        /// </summary>
        public DdexCopyright()
        {
        }

    }
}