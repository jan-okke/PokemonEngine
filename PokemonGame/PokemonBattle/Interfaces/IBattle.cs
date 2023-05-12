using PokemonGame.PokemonBattle.Entities;
using System.Collections.Generic;
using PokemonGame.PokemonBattle.Enums;

namespace PokemonGame.PokemonBattle.Interfaces;

public interface IBattle
{
    void UseMove(Move move);
    void UseMove(string name);
    void UseItem(Item item, Pokemon target);
    void SwitchPokemon(Pokemon target);
    List<Pokemon> GetActiveBattlers();
    BattleType GetBattleType();
    BattleView GetCurrentState();
    bool IsOver();
}