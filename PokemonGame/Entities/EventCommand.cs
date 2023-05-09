using PokemonGame.Enums;

namespace PokemonGame.Entities;

public class EventCommand
{
    public readonly EventCommandType CommandType;
    public readonly string[] Args;

    public EventCommand(EventCommandType commandType, string[] args) 
    {
        CommandType = commandType;
        Args = args;
    }
}