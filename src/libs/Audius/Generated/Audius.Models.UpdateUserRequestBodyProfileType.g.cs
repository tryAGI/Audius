
#nullable enable

namespace Audius
{
    /// <summary>
    /// Type of profile (e.g., 'label' for record labels)
    /// </summary>
    public enum UpdateUserRequestBodyProfileType
    {
        /// <summary>
        ///
        /// </summary>
        Label,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateUserRequestBodyProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserRequestBodyProfileType value)
        {
            return value switch
            {
                UpdateUserRequestBodyProfileType.Label => "label",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserRequestBodyProfileType? ToEnum(string value)
        {
            return value switch
            {
                "label" => UpdateUserRequestBodyProfileType.Label,
                _ => null,
            };
        }
    }
}