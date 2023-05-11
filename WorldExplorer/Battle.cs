using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace WorldExplorer;

public static class BattleCommands
{
    private static IBattle? _battle;

    public static void StartWildBattle(IBattleInitialize initializer, IPokemonParty party, string name, int level)
    {
        _battle = initializer.StartWildBattle(party, name, level);
    }

    public static void UseMove(Move move)
    {
        _battle?.UseMove(move);
    }

    public static BattleView GetView()
    {
        if (_battle is null)
        {
            throw new Exception("No battle started");
        }
        return _battle.GetCurrentState();
    }
}