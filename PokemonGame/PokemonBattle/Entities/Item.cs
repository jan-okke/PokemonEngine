namespace PokemonGame.PokemonBattle.Entities 
{
    public class Item 
    {
        public virtual string Name { get; }
        public virtual string Description { get; }

        public virtual bool IsPokeball => false;
        public virtual bool IsMedicine => false;
        public virtual bool IsBerry => false;
        public virtual bool IsXItem => false;

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Item() {}
    }
}