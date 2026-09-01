
#nullable enable

namespace Audius
{
    /// <summary>
    /// Type of profile (e.g., 'label' for record labels)
    /// </summary>
    public enum CreateUserRequestBodyProfileType
    {
        /// <summary>
        ///
        /// </summary>
        Label,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUserRequestBodyProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUserRequestBodyProfileType value)
        {
            return value switch
            {
                CreateUserRequestBodyProfileType.Label => "label",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUserRequestBodyProfileType? ToEnum(string value)
        {
            return value switch
            {
                "label" => CreateUserRequestBodyProfileType.Label,
                _ => null,
            };
        }
    }
}