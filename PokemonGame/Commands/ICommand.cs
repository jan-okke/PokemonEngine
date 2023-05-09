using PokemonGame.Enums;

namespace PokemonGame.Commands;

public interface ICommand
{
    void ExecuteCommand(PokemonGame game);
}