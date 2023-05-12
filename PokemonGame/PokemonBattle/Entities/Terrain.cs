using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class Terrain
{
    public TerrainEffect Effect { get; }
    private int Turns { get; set; }

    public bool Active => Turns > 0;

    public Terrain(TerrainEffect effect, int startingTurns)
    {
        Effect = effect;
        Turns = startingTurns;
    }

    public void OnTurnEnd()
    {
        Turns--;
    }
}