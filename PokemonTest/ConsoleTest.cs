using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace PokemonTest;

public class ConsoleTest
{
    private readonly IBattle _battle;

    private static string GetCmd()
    {
        Console.Write("> ");
        return Console.ReadLine() ?? "";
    }

    private static string GetFirstWord(string command)
    {
        return command.Split(" ")[0];
    }

    private static string GetSecondWord(string command)
    {
        return command.Split(" ")[1];
    }

    private static string GetThirdWord(string command)
    {
        return command.Split(" ")[2];
    }

    private static string GetFourthWord(string command)
    {
        return command.Split(" ")[3];
    }

    private static string GetPastThirdWord(string command)
    {
        return command.Split(" ", 3)[2];
    }

    public ConsoleTest()
    {
        IPokemonParty party = new PokemonParty(new List<Pokemon>());
        IBattleInitialize initializer = new BattleInitialization();


        while (true)
        {
            var command = GetCmd();

            switch (GetFirstWord(command))
            {
                case "add":
                    switch (GetSecondWord(command))
                    {
                        case "pokemon":
                            party.AddPokemon(Pokemon.GetPokemon(GetThirdWord(command),
                                int.Parse(GetFourthWord(command))));
                            break;
                    }

                    break;
                case "battle":
                    switch (GetSecondWord(command))
                    {
                        case "start":
                            _battle = initializer.StartTrainerBattle(party,
                                new Trainer("Test Trainer", "Hey Test!", "Wow I lost",
                                    Pokemon.GetPokemon("Charmander", 20)));
                            break;
                        case "use":
                            _battle?.UseMove(Move.GetMove(GetPastThirdWord(command)));
                            break;
                    }
                    break;
                case "show":
                    Console.WriteLine(_battle?.GetCurrentState());
                    break;
            }
        }
    }
}