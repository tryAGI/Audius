
#nullable enable

namespace Audius
{
    /// <summary>
    /// Music genre
    /// </summary>
    public enum Genre
    {
        /// <summary>
        ///
        /// </summary>
        Acoustic,
        /// <summary>
        ///
        /// </summary>
        Alternative,
        /// <summary>
        ///
        /// </summary>
        Ambient,
        /// <summary>
        ///
        /// </summary>
        Audiobooks,
        /// <summary>
        ///
        /// </summary>
        Blues,
        /// <summary>
        ///
        /// </summary>
        Classical,
        /// <summary>
        ///
        /// </summary>
        Comedy,
        /// <summary>
        ///
        /// </summary>
        Country,
        /// <summary>
        ///
        /// </summary>
        Dancehall,
        /// <summary>
        ///
        /// </summary>
        DeepHouse,
        /// <summary>
        ///
        /// </summary>
        Devotional,
        /// <summary>
        ///
        /// </summary>
        Disco,
        /// <summary>
        ///
        /// </summary>
        Downtempo,
        /// <summary>
        ///
        /// </summary>
        Drum_Bass,
        /// <summary>
        ///
        /// </summary>
        Dubstep,
        /// <summary>
        ///
        /// </summary>
        Electro,
        /// <summary>
        ///
        /// </summary>
        Electronic,
        /// <summary>
        ///
        /// </summary>
        Experimental,
        /// <summary>
        ///
        /// </summary>
        Folk,
        /// <summary>
        ///
        /// </summary>
        Funk,
        /// <summary>
        ///
        /// </summary>
        FutureBass,
        /// <summary>
        ///
        /// </summary>
        FutureHouse,
        /// <summary>
        ///
        /// </summary>
        GlitchHop,
        /// <summary>
        ///
        /// </summary>
        Hardstyle,
        /// <summary>
        ///
        /// </summary>
        HipHopRap,
        /// <summary>
        ///
        /// </summary>
        House,
        /// <summary>
        ///
        /// </summary>
        Hyperpop,
        /// <summary>
        ///
        /// </summary>
        Jazz,
        /// <summary>
        ///
        /// </summary>
        JerseyClub,
        /// <summary>
        ///
        /// </summary>
        Jungle,
        /// <summary>
        ///
        /// </summary>
        Kids,
        /// <summary>
        ///
        /// </summary>
        Latin,
        /// <summary>
        ///
        /// </summary>
        LoFi,
        /// <summary>
        ///
        /// </summary>
        Metal,
        /// <summary>
        ///
        /// </summary>
        Moombahton,
        /// <summary>
        ///
        /// </summary>
        Podcasts,
        /// <summary>
        ///
        /// </summary>
        Pop,
        /// <summary>
        ///
        /// </summary>
        ProgressiveHouse,
        /// <summary>
        ///
        /// </summary>
        Punk,
        /// <summary>
        ///
        /// </summary>
        R_bSoul,
        /// <summary>
        ///
        /// </summary>
        Reggae,
        /// <summary>
        ///
        /// </summary>
        Rock,
        /// <summary>
        ///
        /// </summary>
        Soundtrack,
        /// <summary>
        ///
        /// </summary>
        SpokenWord,
        /// <summary>
        ///
        /// </summary>
        TechHouse,
        /// <summary>
        ///
        /// </summary>
        Techno,
        /// <summary>
        ///
        /// </summary>
        Trance,
        /// <summary>
        ///
        /// </summary>
        Trap,
        /// <summary>
        ///
        /// </summary>
        TropicalHouse,
        /// <summary>
        ///
        /// </summary>
        Vaporwave,
        /// <summary>
        ///
        /// </summary>
        World,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenreExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Genre value)
        {
            return value switch
            {
                Genre.Acoustic => "Acoustic",
                Genre.Alternative => "Alternative",
                Genre.Ambient => "Ambient",
                Genre.Audiobooks => "Audiobooks",
                Genre.Blues => "Blues",
                Genre.Classical => "Classical",
                Genre.Comedy => "Comedy",
                Genre.Country => "Country",
                Genre.Dancehall => "Dancehall",
                Genre.DeepHouse => "Deep House",
                Genre.Devotional => "Devotional",
                Genre.Disco => "Disco",
                Genre.Downtempo => "Downtempo",
                Genre.Drum_Bass => "Drum & Bass",
                Genre.Dubstep => "Dubstep",
                Genre.Electro => "Electro",
                Genre.Electronic => "Electronic",
                Genre.Experimental => "Experimental",
                Genre.Folk => "Folk",
                Genre.Funk => "Funk",
                Genre.FutureBass => "Future Bass",
                Genre.FutureHouse => "Future House",
                Genre.GlitchHop => "Glitch Hop",
                Genre.Hardstyle => "Hardstyle",
                Genre.HipHopRap => "Hip-Hop/Rap",
                Genre.House => "House",
                Genre.Hyperpop => "Hyperpop",
                Genre.Jazz => "Jazz",
                Genre.JerseyClub => "Jersey Club",
                Genre.Jungle => "Jungle",
                Genre.Kids => "Kids",
                Genre.Latin => "Latin",
                Genre.LoFi => "Lo-Fi",
                Genre.Metal => "Metal",
                Genre.Moombahton => "Moombahton",
                Genre.Podcasts => "Podcasts",
                Genre.Pop => "Pop",
                Genre.ProgressiveHouse => "Progressive House",
                Genre.Punk => "Punk",
                Genre.R_bSoul => "R&B/Soul",
                Genre.Reggae => "Reggae",
                Genre.Rock => "Rock",
                Genre.Soundtrack => "Soundtrack",
                Genre.SpokenWord => "Spoken Word",
                Genre.TechHouse => "Tech House",
                Genre.Techno => "Techno",
                Genre.Trance => "Trance",
                Genre.Trap => "Trap",
                Genre.TropicalHouse => "Tropical House",
                Genre.Vaporwave => "Vaporwave",
                Genre.World => "World",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Genre? ToEnum(string value)
        {
            return value switch
            {
                "Acoustic" => Genre.Acoustic,
                "Alternative" => Genre.Alternative,
                "Ambient" => Genre.Ambient,
                "Audiobooks" => Genre.Audiobooks,
                "Blues" => Genre.Blues,
                "Classical" => Genre.Classical,
                "Comedy" => Genre.Comedy,
                "Country" => Genre.Country,
                "Dancehall" => Genre.Dancehall,
                "Deep House" => Genre.DeepHouse,
                "Devotional" => Genre.Devotional,
                "Disco" => Genre.Disco,
                "Downtempo" => Genre.Downtempo,
                "Drum & Bass" => Genre.Drum_Bass,
                "Dubstep" => Genre.Dubstep,
                "Electro" => Genre.Electro,
                "Electronic" => Genre.Electronic,
                "Experimental" => Genre.Experimental,
                "Folk" => Genre.Folk,
                "Funk" => Genre.Funk,
                "Future Bass" => Genre.FutureBass,
                "Future House" => Genre.FutureHouse,
                "Glitch Hop" => Genre.GlitchHop,
                "Hardstyle" => Genre.Hardstyle,
                "Hip-Hop/Rap" => Genre.HipHopRap,
                "House" => Genre.House,
                "Hyperpop" => Genre.Hyperpop,
                "Jazz" => Genre.Jazz,
                "Jersey Club" => Genre.JerseyClub,
                "Jungle" => Genre.Jungle,
                "Kids" => Genre.Kids,
                "Latin" => Genre.Latin,
                "Lo-Fi" => Genre.LoFi,
                "Metal" => Genre.Metal,
                "Moombahton" => Genre.Moombahton,
                "Podcasts" => Genre.Podcasts,
                "Pop" => Genre.Pop,
                "Progressive House" => Genre.ProgressiveHouse,
                "Punk" => Genre.Punk,
                "R&B/Soul" => Genre.R_bSoul,
                "Reggae" => Genre.Reggae,
                "Rock" => Genre.Rock,
                "Soundtrack" => Genre.Soundtrack,
                "Spoken Word" => Genre.SpokenWord,
                "Tech House" => Genre.TechHouse,
                "Techno" => Genre.Techno,
                "Trance" => Genre.Trance,
                "Trap" => Genre.Trap,
                "Tropical House" => Genre.TropicalHouse,
                "Vaporwave" => Genre.Vaporwave,
                "World" => Genre.World,
                _ => null,
            };
        }
    }
}