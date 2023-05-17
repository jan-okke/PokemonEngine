using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Interfaces;

namespace WorldExplorer;

public sealed class Player
{
    private GameMap? _currentMap;
    public GameMap? CurrentMap
    {
        get => _currentMap;
        private set
        {
            _currentMap = value;
            value?.OnEnter();
        }
    }

    private static Player? instance = null;

    static Player()
    {
    }

    private Player()
    {
        
    }

    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Player();
                instance.CurrentMap = GameMaps.GetInstance().GetMap(Settings.StartMap);
                
            }

            return instance;
        }
    }

    private readonly IPokemonParty _party = new PokemonParty(pokemons: null);
    
    public void GoNorth()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap?.GetConnection(Direction.North));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void GoSouth()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap?.GetConnection(Direction.South));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void GoEast()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap?.GetConnection(Direction.East));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void GoWest()
    {
        var newMap = GameMaps.GetInstance().GetMap(CurrentMap?.GetConnection(Direction.West));
        if (newMap is null) return;
        CurrentMap = newMap;
    }

    public void AddPokemon(string name, int level)
    {
        _party.AddPokemon(Pokemon.GetPokemon(name, level));
    }

    public IPokemonParty GetParty()
    {
        return _party;
    }
}