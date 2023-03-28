namespace PokemonGame.Commands
{
    public class RotateCommand : ICommand
    {
        public string Direction { get; set; }

        public RotateCommand(string direction)
        {
            Direction = direction;
        }

        public void ExecuteCommand(PokemonGame game)
        {
            game.RotatePlayer(Direction);
        }
    }
}