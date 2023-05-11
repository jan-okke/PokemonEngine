namespace WorldExplorer;

public class Player
{
    public GameMap CurrentMap;
    private static Player? _instance;

    private Player()
    {
        CurrentMap = GameMaps.GetInstance().GetMap(Settings.StartMap) ?? throw new InvalidOperationException();
    }

    public static Player GetInstance()
    {
        return _instance ??= new Player();
    }

    public void GoNorth()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap.GetConnection(Direction.North));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void GoSouth()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap.GetConnection(Direction.South));
        if (newMap is null) return;
        CurrentMap = newMap;
    }
}