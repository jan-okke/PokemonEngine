using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Entities;

public class Terrain
{
    public event OnTerrainEnd? OnTerrainEnd;
    public event OnTerrainCreate? OnTerrainCreate;
    public TerrainEffect Effect { get; }
    private int Turns { get; set; }

    public bool Active => Turns > 0;

    public Terrain(TerrainEffect effect, int startingTurns)
    {
        Effect = effect;
        Turns = startingTurns;
        OnTerrainCreate?.Invoke(this, new OnTerrainCreateArgs());
    }

    private void OnTurnEnd()
    {
        Turns--;
        if (Turns == 0)
        {
            OnTerrainEnd?.Invoke(this, new OnTerrainEndArgs());
        }
    }

    public void HandleOnTurnEnd(object sender, TurnEndEventHandlerArgs e)
    {
        OnTurnEnd();
    }
}