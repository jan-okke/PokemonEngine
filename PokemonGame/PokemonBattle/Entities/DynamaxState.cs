namespace PokemonGame.PokemonBattle.Entities;

public class DynamaxState
{
    public int Turns { get; internal set; }
    public bool Active => Turns > 0;

    public DynamaxState(int startingTurns = 3)
    {
        Turns = startingTurns;
    }
}