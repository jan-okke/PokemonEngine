using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public interface ICommand
    {
        void ExecuteCommand(PokemonGame game);
    }
}