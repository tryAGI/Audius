
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTipsCurrentUserFollows
    {
        /// <summary>
        ///
        /// </summary>
        Receiver,
        /// <summary>
        ///
        /// </summary>
        Sender,
        /// <summary>
        ///
        /// </summary>
        SenderOrReceiver,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTipsCurrentUserFollowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTipsCurrentUserFollows value)
        {
            return value switch
            {
                GetTipsCurrentUserFollows.Receiver => "receiver",
                GetTipsCurrentUserFollows.Sender => "sender",
                GetTipsCurrentUserFollows.SenderOrReceiver => "sender_or_receiver",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTipsCurrentUserFollows? ToEnum(string value)
        {
            return value switch
            {
                "receiver" => GetTipsCurrentUserFollows.Receiver,
                "sender" => GetTipsCurrentUserFollows.Sender,
                "sender_or_receiver" => GetTipsCurrentUserFollows.SenderOrReceiver,
                _ => null,
            };
        }
    }
}