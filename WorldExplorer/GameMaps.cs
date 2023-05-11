namespace WorldExplorer;

public class GameMaps
{
    private static GameMaps? _instance;
    private readonly Dictionary<string, GameMap> _maps;

    private GameMaps()
    {
        _maps = new Dictionary<string, GameMap>();
        CreateMaps();
    }

    public static GameMaps GetInstance()
    {
        return _instance ??= new GameMaps();
    }

    private void CreateMaps()
    {
        _maps.Add("Pallet Town", new GameMap("Pallet Town", new Connection(Direction.North, "Route 1")));
        _maps.Add("Route 1", new GameMap("Route 1", new Connection(Direction.South, "Pallet Town"), new Connection(Direction.North, "Viridian City")));
        _maps.Add("Viridian City", new GameMap("Viridian City", new Connection(Direction.South, "Route 1")));
    }

    public GameMap? GetMap(string? name)
    {
        return name is null ? null : !_maps.ContainsKey(name) ? null : _maps[name];
    }
}