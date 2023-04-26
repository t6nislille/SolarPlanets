using SolarPlanets.Models;
namespace SolarPlanets.Services
{
    internal class PlanetServices
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
        };

        public static List<Planet> GetAllPlanets()
        {
            return planets;
        }

        public static Planet GetPlanet(string planetName)
        {
            return planets.Where(planet => planet.Name == planetName).FirstOrDefault();
        }

        public static List<Planet> GetFeaturedPlanets()
        {
            var randomizedPlanets = planets.OrderBy(item => new Random().Next());

            return randomizedPlanets.Take(2).ToList();
        }
    }
}
