using PokemonGame.PokemonBattle.Entities;
using PokemonGame.Entities;

namespace PokemonGame.PokemonBattle.Interfaces
{
    public interface ISingleBattleCommands
    {
        void UseMove(Move move);
        void UseItem(Player player, Item item, Pokemon target);
        void SwitchPokemon(Pokemon pokemon);
        void Run();
    }
}