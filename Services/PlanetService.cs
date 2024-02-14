using PlanetsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsApp.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smol planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "The hot place",
                HeroImage = "venus.png",
                Description = "Out of all the planets in the solar system, Venus is the most similar to Earth. In fact, venus is often called Earth's sister planet. As similar as it in some ways, however, it is also very different in others.",
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
                Name = "Earth",
                Subtitle = "That small, but lively rock",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only place known in the universe where life has originated and found habitability. While Earth may not contain the largest volumes of water in the Solar System, only Earth sustains liquid surface water, extending over 70.8% of the Earth with its ocean, making Earth an ocean world.",
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
                Name = "Mars",
                Subtitle = "The red planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun and the second-smallest planet in the Solar System, larger only than Mercury. In the English language, Mars is named for the Roman god of war. Mars is a terrestrial planet with a thin atmosphere and has a crust primarily composed of elements similar to Earth's crust, as well as a core made of iron and nickel.",
                AccentColorStart = Color.FromArgb("#23035"),
                AccentColorEnd = Color.FromArgb("#eb3332"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "That planet with rings",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius of about nine and a half times that of Earth. It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "Cold ball",
                HeroImage = "uranus.png",
                Description = "Uranus is the 7th planet from the Sun. It is named after Greek sky deity Uranus (Caelus), who in Greek mythology is the father of Cronus (Saturn), a grandfather of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus has the third-largest planetary radius and fourth-largest planetary mass in the Solar System. The planet is similar in composition to Neptune, and both have bulk chemical compositions which differ from those of the other two giant planets, Jupiter and Saturn (the gas giants).",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg"
                }
            },
            new()
            {
                Name = " Pluto",
                Subtitle = "Dwarf, not a planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper belt, a ring of bodies beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It is the largest known trans-Neptunian object by volume, by a small margin, but is slightly less massive than Eris. Like other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has only one sixth the mass of Earth's moon, and one third its volume. ",
                AccentColorStart = Color.FromArgb("#fcba03"),
                AccentColorEnd = Color.FromArgb("#91721a"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/d/d3/Global_LORRI_mosaic_of_Pluto_in_true_colour.jpg",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/edu_what_is_pluto_1.png",
                    "https://www.nasa.gov/sites/default/files/thumbnails/image/edu_what_is_pluto_2.png"
                }
            },
            new()
            {
                Name = " Ceres",
                Subtitle = "The only dwarf planet located in the inner solar system.",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to be explored by a spacecraft.\r\n\r\nCalled an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive.\r\n\r\nCeres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
                AccentColorStart = Color.FromArgb("#aba491"),
                AccentColorEnd = Color.FromArgb("#242424"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/stellar_items/image_files/704_feature_1600x900_ceres.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://i.ytimg.com/vi/nJiw2NxqoBU/mqdefault.jpg"
                }
            },
            new()
            {
                Name = " Haumea",
                Subtitle = "Santa",
                HeroImage = "haumea.png",
                Description = "Haumea is an oval-shaped dwarf planet that is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football. Everything we know about Haumea is from observations with ground-based telescopes from around the world.",
                AccentColorStart = Color.FromArgb("#8f4021"),
                AccentColorEnd = Color.FromArgb("#3d1709"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fnineplanets.org%2Fwp-content%2Fuploads%2F2019%2F11%2Fdwarf-planet-haumea.jpg&f=1&nofb=1&ipt=2353cf8541880f463de539292c3f962eed1f4a5d4dd399e753cdbc134ff1fd7c&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.futura-sciences.com%2Fbuildsv6%2Fimages%2Fwide1920%2F9%2F0%2F0%2F90064315b8_114804_planete-naine-haumea-anneaux.jpg&f=1&nofb=1&ipt=e22832a096ae11e6c25fa4d664ec7bd04d1f985ee7212bab59d351787e6b9253&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2F1.bp.blogspot.com%2F-J-jqHGtMLp4%2FX50fQU5nAPI%2FAAAAAAAABRQ%2FQ-E0DDHEri8Y2kM6rJa2e4c3zrRN_clSQCLcBGAsYHQ%2Fs1600%2F723_feature_1600x900_haumea.jpg&f=1&nofb=1&ipt=1decf174306217197eb4293f077c12036ab5e801d0e27eb76925d9c69c614573&ipo=images"
                }
            },
            new()
            {
                Name = " MakeMake",
                Subtitle = "Rapanui god of fertility",
                HeroImage = "makemake.png",
                Description = "Dwarf planet Makemake – along with Pluto, Haumea, and Eris – is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.",
                AccentColorStart = Color.FromArgb("#ffab52"),
                AccentColorEnd = Color.FromArgb("#400b2b"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fnineplanets.org%2Fwp-content%2Fuploads%2F2020%2F11%2Fmakemake-1.jpg&f=1&nofb=1&ipt=72abc9129831e14de1b7dd001cb8cae54b4e06b885cc0985f482120581ff1bcb&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Feasyscienceforkids.com%2Fwp-content%2Fuploads%2F2019%2F07%2FMakemake-19-4-1.jpg&f=1&nofb=1&ipt=25e443b976c7eb0ab4c704f76e209653f228b4c441cc7f8dedce00ff2099ea08&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.science.org%2Fdo%2F10.1126%2Fscience.aaf9978%2Fabs%2Fmakemake.jpg&f=1&nofb=1&ipt=d8291de3bdd0d5a86395385a00497d52ebf6bbbd5f3e5b985a4a940016d6a16a&ipo=images"
                }
            },
            new()
            {
                Name = " Eris",
                Subtitle = "Ancient Greek goddess of discord and strife",
                HeroImage = "eris.png",
                Description = "The discovery of Eris help trigger a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.\r\n\r\nEris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory survey of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute of Technology; Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University.",
                AccentColorStart = Color.FromArgb("#ff6beb"),
                AccentColorEnd = Color.FromArgb("#330821"),
                Images = new()
                {
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fsolarstory.net%2Fimg%2Farticles%2Fbig%2Fartists-impression-of-the-dwarf-planet-eris.jpg&f=1&nofb=1&ipt=86380bb2def0a5fc484e18361d28a05289a68543f521bf9e35c35db00815d86c&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.mos.cms.futurecdn.net%2FdZqUSGT8ZrMagExRfcrKLJ.jpg&f=1&nofb=1&ipt=13a7df00aed1d6c12bf15799053854c5cad41c35dab4a180b57defcc31b1c647&ipo=images",
                    "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.nkfu.com%2Fwp-content%2Fuploads%2F2020%2F09%2FEris-cuce-gezegeni.jpg&f=1&nofb=1&ipt=b1ea543a55a9d681dacf49e56e979106828b0954bc13f9951edbac6c86328c31&ipo=images"
                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the ocean",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and the farthest known planet in the Solar System. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth, and slightly more massive than its near-twin Uranus. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            }
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var rnd = new Random();
            var randomizedPlanets = planets.OrderBy(item => rnd.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
