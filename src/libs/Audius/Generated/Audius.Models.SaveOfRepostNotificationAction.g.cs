
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaveOfRepostNotificationAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Specifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Timestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.SaveOfRepostNotificationActionData Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveOfRepostNotificationAction" /> class.
        /// </summary>
        /// <param name="specifier"></param>
        /// <param name="type"></param>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveOfRepostNotificationAction(
            string specifier,
            string type,
            int timestamp,
            global::Audius.SaveOfRepostNotificationActionData data)
        {
            this.Specifier = specifier ?? throw new global::System.ArgumentNullException(nameof(specifier));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Timestamp = timestamp;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveOfRepostNotificationAction" /> class.
        /// </summary>
        public SaveOfRepostNotificationAction()
        {
        }

    }
}