using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public interface ICommand
    {
        EventCommandType GetEventCommandType();
    }
}