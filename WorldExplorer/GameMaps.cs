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
        if (_instance is null)
        {
            _instance = new GameMaps();
        }

        return _instance;
    }

    private void CreateMaps()
    {
        _maps.Add("Pallet Town", new GameMap("Pallet Town", new [] { new Connection(Direction.North, "Route 1")}, null,
            Scripts.StarterChoice));
        _maps.Add("Route 1", new GameMap("Route 1", new [] { new Connection(Direction.South, "Pallet Town"), new Connection(Direction.North, "Viridian City")}, new Dictionary<string, int>()
        {
            ["Pidgey"] = 2,
            ["Rattata"] = 3
        }, null));
        _maps.Add("Viridian City", new GameMap("Viridian City", new [] {new Connection(Direction.South, "Route 1")}, null, null));
    }

    public GameMap? GetMap(string? name)
    {
        return name is null ? null : !_maps.ContainsKey(name) ? null : _maps[name];
    }
}