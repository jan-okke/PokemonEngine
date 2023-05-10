namespace PokemonGame.PokemonBattle.Entities;

public class Gravity
{
    public int Turns { get; internal set; }

    public bool Active => Turns > 0;
    public Gravity(int startingTurns) 
    {
        Turns = startingTurns;
    }
}