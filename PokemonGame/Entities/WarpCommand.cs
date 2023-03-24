using PokemonGame.Enums;

namespace PokemonGame.Entities
{
    public class WarpCommand : ICommand
    {
        public int MapID;
        public int X;
        public int Y;

        public WarpCommand(int mapID, int x, int y) {
            MapID = mapID;
            X = x;
            Y = y;
        }

        public EventCommandType GetEventCommandType() {
            return EventCommandType.WarpCommand;
        }

    }
}