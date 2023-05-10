namespace PokemonGame.PokemonBattle.Entities;

public abstract class Ability
{
    public virtual string Name => "";
    public virtual string Description => "";
    public virtual bool IgnoresOtherAbilities => false;

    public bool HasName(string name)
    {
        return Name == name;
    }
}