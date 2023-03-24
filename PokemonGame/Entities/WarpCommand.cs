using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public class WarpCommand : ICommand
    {
        // public int MapID; TODO later
        public int X;
        public int Y;

        public WarpCommand(int x, int y) {
            X = x;
            Y = y;
        }

        public EventCommandType GetEventCommandType() {
            return EventCommandType.WarpCommand;
        }

    }
}