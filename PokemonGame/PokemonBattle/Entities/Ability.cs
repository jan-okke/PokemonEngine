namespace PokemonGame.PokemonBattle.Entities;

public class Ability
{
    public virtual string Name { get; }
    public virtual string Description { get; }

    public Ability(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public Ability()
    {
    }
}