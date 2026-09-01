
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListenStreakReminderNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streak")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Streak { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenStreakReminderNotificationActionData" /> class.
        /// </summary>
        /// <param name="streak"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenStreakReminderNotificationActionData(
            int streak)
        {
            this.Streak = streak;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenStreakReminderNotificationActionData" /> class.
        /// </summary>
        public ListenStreakReminderNotificationActionData()
        {
        }

    }
}