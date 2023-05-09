using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Interfaces;

public interface IBattleInitialize
{
    IBattle StartTrainerBattle(IPokemonParty party, Trainer trainer);
    IBattle StartWildBattle(IPokemonParty party, Pokemon pokemon);
    IBattle StartWildBattle(IPokemonParty party, string name, int level);
}