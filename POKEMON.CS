namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string[] Types { get; set; }

        public int BaseExperience { get; set; }
    }
}
