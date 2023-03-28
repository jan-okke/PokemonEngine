namespace PokemonGame.Commands
{
    public class MoveCommand : ICommand
    {
        public string Direction { get; set; }

        public MoveCommand(string direction)
        {
            Direction = direction;
        }

        public void ExecuteCommand(PokemonGame game)
        {
            game.MovePlayer(Direction);
        }
    }
}