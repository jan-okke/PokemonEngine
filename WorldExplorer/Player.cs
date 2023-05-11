using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace WorldExplorer;

public class Player
{
    private GameMap _currentMap;
    public GameMap CurrentMap
    {
        get => _currentMap;
        private set
        {
            _currentMap = value;
            value.OnEnter();
        }
    }

    private static Player? _instance;
    private readonly IPokemonParty _party;

    private Player()
    {
        _currentMap = GameMaps.GetInstance().GetMap(Settings.StartMap) ?? throw new InvalidOperationException();
        _party = new PokemonParty(pokemons: null);
        _currentMap.OnEnter();
    }

    public static Player GetInstance()
    {
        if (_instance is null)
        {
            _instance = new Player();
        }

        return _instance;
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

    public void GoEast()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap.GetConnection(Direction.East));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void GoWest()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap.GetConnection(Direction.West));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void AddPokemon(string name, int level)
    {
        _party.AddPokemon(Pokemon.GetPokemon(name, level));
    }
}