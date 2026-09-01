
#nullable enable

namespace Audius
{
    /// <summary>
    /// Music mood
    /// </summary>
    public enum Mood
    {
        /// <summary>
        ///
        /// </summary>
        Aggressive,
        /// <summary>
        ///
        /// </summary>
        Brooding,
        /// <summary>
        ///
        /// </summary>
        Cool,
        /// <summary>
        ///
        /// </summary>
        Defiant,
        /// <summary>
        ///
        /// </summary>
        Easygoing,
        /// <summary>
        ///
        /// </summary>
        Empowering,
        /// <summary>
        ///
        /// </summary>
        Energizing,
        /// <summary>
        ///
        /// </summary>
        Excited,
        /// <summary>
        ///
        /// </summary>
        Fiery,
        /// <summary>
        ///
        /// </summary>
        Gritty,
        /// <summary>
        ///
        /// </summary>
        Melancholy,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Peaceful,
        /// <summary>
        ///
        /// </summary>
        Romantic,
        /// <summary>
        ///
        /// </summary>
        Rowdy,
        /// <summary>
        ///
        /// </summary>
        Sensual,
        /// <summary>
        ///
        /// </summary>
        Sentimental,
        /// <summary>
        ///
        /// </summary>
        Serious,
        /// <summary>
        ///
        /// </summary>
        Sophisticated,
        /// <summary>
        ///
        /// </summary>
        Stirring,
        /// <summary>
        ///
        /// </summary>
        Tender,
        /// <summary>
        ///
        /// </summary>
        Upbeat,
        /// <summary>
        ///
        /// </summary>
        Yearning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MoodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mood value)
        {
            return value switch
            {
                Mood.Aggressive => "Aggressive",
                Mood.Brooding => "Brooding",
                Mood.Cool => "Cool",
                Mood.Defiant => "Defiant",
                Mood.Easygoing => "Easygoing",
                Mood.Empowering => "Empowering",
                Mood.Energizing => "Energizing",
                Mood.Excited => "Excited",
                Mood.Fiery => "Fiery",
                Mood.Gritty => "Gritty",
                Mood.Melancholy => "Melancholy",
                Mood.Other => "Other",
                Mood.Peaceful => "Peaceful",
                Mood.Romantic => "Romantic",
                Mood.Rowdy => "Rowdy",
                Mood.Sensual => "Sensual",
                Mood.Sentimental => "Sentimental",
                Mood.Serious => "Serious",
                Mood.Sophisticated => "Sophisticated",
                Mood.Stirring => "Stirring",
                Mood.Tender => "Tender",
                Mood.Upbeat => "Upbeat",
                Mood.Yearning => "Yearning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mood? ToEnum(string value)
        {
            return value switch
            {
                "Aggressive" => Mood.Aggressive,
                "Brooding" => Mood.Brooding,
                "Cool" => Mood.Cool,
                "Defiant" => Mood.Defiant,
                "Easygoing" => Mood.Easygoing,
                "Empowering" => Mood.Empowering,
                "Energizing" => Mood.Energizing,
                "Excited" => Mood.Excited,
                "Fiery" => Mood.Fiery,
                "Gritty" => Mood.Gritty,
                "Melancholy" => Mood.Melancholy,
                "Other" => Mood.Other,
                "Peaceful" => Mood.Peaceful,
                "Romantic" => Mood.Romantic,
                "Rowdy" => Mood.Rowdy,
                "Sensual" => Mood.Sensual,
                "Sentimental" => Mood.Sentimental,
                "Serious" => Mood.Serious,
                "Sophisticated" => Mood.Sophisticated,
                "Stirring" => Mood.Stirring,
                "Tender" => Mood.Tender,
                "Upbeat" => Mood.Upbeat,
                "Yearning" => Mood.Yearning,
                _ => null,
            };
        }
    }
}