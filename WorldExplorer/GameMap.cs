using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace WorldExplorer;

public class GameMap
{
    private string Name { get; }
    private List<Connection> Connections { get; } = new();
    private Dictionary<string, int> Pokemons { get; } = new();
    private Action? MapEnterScript { get; }

    public GameMap(string name, IEnumerable<Connection> connections, Dictionary<string, int>? pokemons, Action? mapEnterScript)
    {
        Name = name;
        Connections.AddRange(connections);
        if (pokemons != null) Pokemons = pokemons;
        MapEnterScript = mapEnterScript;
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

    public void Encounter(IPokemonParty playerParty)
    {
        var pokemon = Pokemons.Keys.ElementAt(new Random().Next(Pokemons.Keys.Count));
        var level = Pokemons[pokemon];
        
        BattleCommands.StartWildBattle(new BattleInitialization(), playerParty, pokemon, level);
    }

    public void OnEnter()
    {
        MapEnterScript?.Invoke();
    }
}