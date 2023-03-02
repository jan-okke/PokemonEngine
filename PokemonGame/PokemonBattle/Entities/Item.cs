namespace PokemonGame.PokemonBattle.Entities 
{
    public class Item 
    {
        public virtual string Name { get; }
        public virtual string Description { get; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Item() {}
    }
}