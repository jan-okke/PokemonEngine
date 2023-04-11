using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Interfaces
{
    public interface IBattleInitialize
    {
        void StartTrainerBattle(Trainer trainer);
        void StartWildBattle(Pokemon pokemon);
        void StartWildBattle(string name, int level);
    }
}