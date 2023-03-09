using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Extensions;
using PokemonGame.PokemonBattle.Actions;
using PokemonGame.PokemonBattle.Data.Pokemons;
using PokemonGame.PokemonBattle.Data.Moves;

public class ConsoleTest {

    private PokemonParty party;
    private Battle battle;

    private string GetCmd() {
        Console.Write("> ");
        return Console.ReadLine() ?? "";
    }

    private string GetFirstWord(string command) {
        return command.Split(" ")[0];
    }

    private string GetSecondWord(string command) {
        return command.Split(" ")[1];
    }

    private string GetThirdWord(string command) {
        return command.Split(" ")[2];
    }
    
    private string GetFourthWord(string command) {
        return command.Split(" ")[3];
    }

    public ConsoleTest() {
        party = new(new List<Pokemon>());

        while (true) {
            var command = GetCmd();

            switch (GetFirstWord(command)) {
                case "add": switch (GetSecondWord(command)) {
                    case "pokemon": party.Pokemons.Add(Pokemon.GetPokemon(GetThirdWord(command), int.Parse(GetFourthWord(command)))); break;
                } break;
                case "battle": switch (GetSecondWord(command)) {
                    case "start": var opp = new Abomasnow(50); opp.CalculateStats(); opp.HealHP(); opp.LearnMove(new Blizzard()); battle = BattleActions.StartWildBattle(party, opp); break;
                    case "use": if (battle is null) break; battle.UseMove(party.GetFirstAlivePokemon(), battle.EnemyParty.GetFirstAlivePokemon(), Move.GetMove(GetThirdWord(command))); break;
                } break;
                case "show": if (battle is null || !battle.IsOngoing) break; Console.WriteLine($"Active: {battle.IsOngoing} Your Pkmn: {battle.PlayerParty.GetFirstAlivePokemon()} ({battle.PlayerParty.GetFirstAlivePokemon().CurrentHP} HP) Enemy Pkmn: {battle.EnemyParty.GetFirstAlivePokemon()} ({battle.EnemyParty.GetFirstAlivePokemon().CurrentHP} HP)"); break;
            }
        }
    }
}