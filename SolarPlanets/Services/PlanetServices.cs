namespace SolarPlanets.Services
{
    internal static class PlanetServices
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "  Mercury",
                Subtitle = "    The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first of the four terrestrial planets. This means it is a planet made mostly of rock. The planets closest to the Sun—Venus, Earth, and Mars—are the other three.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },

            new()
            {
                Name = " Venus",
                Subtitle = "   The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = " Earth",
                Subtitle = "   The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = " Mars",
                Subtitle = "   The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars?",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "   The gas giant",
                HeroImage = "jupiter.png",
                Description = "The planet Jupiter is the first of the gas giant planets. Made mostly of gas, they include Jupiter, Saturn, Uranus, and Neptune.\n\nJupiter is first among the planets in terms of size and mass. Its diameter is 11 times bigger than Earth, and its mass is 2.5 times greater than all the other planets combined. The “Great Red Spot” on Jupiter is actually a raging storm.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = " Saturn",
                Subtitle = "   The ring planet",
                HeroImage = "saturn.png",
                Description = "Most people know about the rings around Saturn, because they are the brightest and most colorful. These rings are made mainly out of ice particles orbiting the planet. While the rings themselves seem big, the particles are very small, usually no more than 10 feet (3 meters) wide.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "   The cold ball",
                HeroImage = "uranus.png",
                Description = "Uranus is the first planet so far away from the Earth that it can only be seen with the use of a telescope. When it was first discovered in 1781, scientists didn't know what they had found. As astronomers studied the object more closely, they discovered that it had a circular orbit around the Sun. They had found the seventh planet.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "   Eighth & fathest-away",
                HeroImage = "neptune.png",
                Description = "Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = " Pluto",
                Subtitle = "   The only world named by an 11-year-old girl",
                HeroImage = "pluto.png",
                Description = "Pluto is a complex world of ice mountains and frozen plains. Once considered the ninth planet, Pluto is the best known of a new class of worlds called dwarf planets.",
                AccentColorStart = Color.FromArgb("#00008B"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBckFEIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1120618ad30f3328931c4d666bd1087ae9998d7b/PIA20213_1200w.jpg?disposition=attachment",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBa0FGIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--fa3ee29d4094fd4a72b211b24a013a0697ef6c65/pluto_lorri_ralph_20150713_2017.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBczhFIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--26a2b6f6e25196e5f47858d8f1865fb9b520c049/nh-apluto-mountains-plains-9-17-15_0.jpg"
                }
            },

            new()
            {
                Name = " Ceres",
                Subtitle = "   From a asteroid to a dwarf",
                HeroImage = "ceres.png",
                Description = "Ceres makes up almost a third of the asteroid belt's total mass, but it is still far smaller than Earth's Moon. Ceres is heavily cratered with large amounts of ice underground.",
                AccentColorStart = Color.FromArgb("#D3D3D3"),
                AccentColorEnd = Color.FromArgb("#696969"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBczRHIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--e1ba19d37ddff74f0b44a1061e61b7314a430c73/PIA22480_hires.jpg?disposition=attachment",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBc0FHIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--e96b10366d38fc63f0ad9aa1d3c96100710f5150/PIA22761_hires.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdFlHIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--7a2a1208ab2f29f1bd20ea56db2f40511dcc9874/PIA22642_hires.jpg"
                }
            },

            new()
            {
                Name = " Makemake",
                Subtitle = "   Second-brightest object",
                HeroImage = "makemake.png",
                Description = "Along with fellow dwarf planets Pluto, Eris, and Haumea, Makemake is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#ADD8E6"),
                AccentColorEnd = Color.FromArgb("#9370DB"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBclJPIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--8124d169f5d84df689d662d4a5b584dafae25be5/Makemake_moon.jpeg",
                    "https://www.universetoday.com/wp-content/uploads/2008/07/Makemake-1280x720.jpg",
                    "https://solarsystem.nasa.gov/system/stellar_items/image_files/705_feature_1600x900_makemake.jpg"
                }
            },

            new()
            {
                Name = " Haumea",
                Subtitle = "   Santa",
                HeroImage = "haumea.png",
                Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune.",
                AccentColorStart = Color.FromArgb("#D2B48C"),
                AccentColorEnd = Color.FromArgb("#8B4513"),
                Images = new()
                {
                    "https://scx1.b-cdn.net/csz/news/800a/2017/59de5fc415107.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBZ1lSIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--75ac289f8ffa148b3f12097ebadc2291782633a2/haumea_th.jpg",
                    "https://static.wikia.nocookie.net/expanse/images/1/1f/Haumea_in_Celestia.jpg/revision/latest?cb=20200206143331"
                }
            },

            new()
            {
                Name = " Eris",
                Subtitle = "   Pluto-sized world",
                HeroImage = "eris.png",
                Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto, but it is three times farther from the Sun. One orbit takes about 557 years.",
                AccentColorStart = Color.FromArgb("#4B0082"),
                AccentColorEnd = Color.FromArgb("#8B0000"),
                Images = new()
                {
                    "https://cdn.eso.org/images/screen/eso1142a.jpg",
                    "https://theplanets.org/123/2021/10/Eris-Facts.png",
                    "https://www.tornado-studios.com/sites/default/files/styles/slider_full/public/products/498/gallery/eris_thumbnail_square0000.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
