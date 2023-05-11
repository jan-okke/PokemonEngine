namespace WorldExplorer;

public abstract class Program
{
    public static void Main(string[] args)
    {
        var player = Player.GetInstance();

        player.CurrentMap.Display();
        while (true)
        {
            var command = Command.GetCommand();
            ParseCommand(command, player);
        }
    }

    private static void ParseCommand(Command command, Player player)
    {
        switch (command.GetFirstWord())
        {
            case "go":
                switch (command.GetSecondWord())
                {
                    case "up" or "north":
                        player.GoNorth();
                        player.CurrentMap.Display();
                        break;
                    case "down" or "south":
                        player.GoSouth();
                        player.CurrentMap.Display();
                        break;
                }
                break;
            case "look":
                player.CurrentMap.DisplayConnections();
                break;
        }
    }
}