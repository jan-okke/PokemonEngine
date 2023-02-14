using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public class EventCommand
    {
        public EventCommandType CommandType;
        public string[] Args;

        public EventCommand(EventCommandType commandType, string[] args) 
        {
            CommandType = commandType;
            Args = args;
        }
    }
}