using PokemonGame.PokemonBattle.Interfaces;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleView
{
    private int PlayerPokemonHp { get; }
    private int PlayerPokemonMaxHp { get; }
    private string PlayerPokemonName { get; }
    private int EnemyPokemonHp { get; }
    private int EnemyPokemonMaxHp { get; }
    private string EnemyPokemonName { get; }
    private int CurrentTurn { get; }

    public BattleView(int currentTurn, Pokemon playerPokemon, Pokemon opponentPokemon)
    {
        PlayerPokemonHp = playerPokemon.CurrentHP;
        PlayerPokemonMaxHp = playerPokemon.Stats.HP;
        PlayerPokemonName = playerPokemon.Name;
        EnemyPokemonHp = opponentPokemon.CurrentHP;
        EnemyPokemonMaxHp = opponentPokemon.Stats.HP;
        EnemyPokemonName = opponentPokemon.Name;
        CurrentTurn = currentTurn;
    }

    public override string ToString()
    {
        return $"Turn {CurrentTurn}\n" +
               $"Player Pokemon ({PlayerPokemonName}): {PlayerPokemonHp} / {PlayerPokemonMaxHp}\n" +
               $"Enemy Pokemon ({EnemyPokemonName}): {EnemyPokemonHp} / {EnemyPokemonMaxHp}";
    }
}