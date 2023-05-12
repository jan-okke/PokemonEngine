using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace WorldExplorer;

public static class BattleCommands
{
    private static IBattle? _battle;

    public static void StartWildBattle(IBattleInitialize initializer, IPokemonParty party, string name, int level)
    {
        Console.WriteLine("Starting a battle!");
        _battle = initializer.StartWildBattle(party, name, level);
        Loop();
    }

    private static void UseMove(Move move)
    {
        _battle?.UseMove(move);
    }

    private static void UseMove(string name)
    {
        _battle?.UseMove(name);
    }

    private static BattleView GetView()
    {
        if (_battle is null)
        {
            throw new Exception("No battle started");
        }
        return _battle.GetCurrentState();
    }

    private static void Loop()
    {
        while (_battle != null && !_battle.IsOver())
        {
            var view = GetView();
            Console.WriteLine(view);
            var command = Command.GetCommand();
            switch (command.GetFirstWord())
            {
                case "use":
                    switch (command.GetSecondWord())
                    {
                        case "move":
                            UseMove(command.GetThirdWord());
                            break;
                    }
                    break;
            }
            
        }
    }
}