namespace WorldExplorer;

public class GameMap
{
    private string Name { get; }
    private List<Connection> Connections { get; } = new List<Connection>();

    public GameMap(string name, params Connection[] connections)
    {
        Name = name;
        Connections.AddRange(connections);
    }

    public string? GetConnection(Direction direction)
    {
        return Connections.All(c => c.Direction != direction) ? null : Connections.FirstOrDefault(c => c.Direction == direction)?.TargetMap;
    }

    public void Display()
    {
        Console.WriteLine($"You are now at {Name}");
    }

    public void DisplayConnections()
    {
        Console.WriteLine($"Current Map: {Name}");
        foreach (var connection in Connections)
        {
            Console.WriteLine($"[{connection.Direction}] {connection.TargetMap}");
        }
    }
}