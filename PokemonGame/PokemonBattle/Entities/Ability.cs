namespace PokemonGame.PokemonBattle.Entities 
{
    public class Ability 
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Ability(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Ability() { }
    }
}