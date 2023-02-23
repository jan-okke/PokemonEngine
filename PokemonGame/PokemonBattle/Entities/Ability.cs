namespace PokemonGame.PokemonBattle.Entities 
{
    public class Ability 
    {
        public string Name { get; }
        public string Description { get; }
        public Ability(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}