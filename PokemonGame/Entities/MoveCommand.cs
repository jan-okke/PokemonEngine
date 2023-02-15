using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public class MoveCommand
    {
        public string Direction { get; set; }
        public EventCommandType CommandType { get; set; }

        public MoveCommand(string direction, EventCommandType commandType)
        {
            Direction = direction;
            CommandType = commandType;
        }
    }
}