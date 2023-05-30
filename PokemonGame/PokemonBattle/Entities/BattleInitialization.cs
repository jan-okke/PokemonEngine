using PokemonGame.PokemonBattle.Interfaces;

namespace PokemonGame.PokemonBattle.Entities;

public class BattleInitialization : IBattleInitialize
{
    public IBattle StartTrainerBattle(IPokemonParty party, Trainer trainer)
    {
        return new Battle(party, trainer.Party);
    }

    public IBattle StartWildBattle(IPokemonParty party, Pokemon pokemon)
    {
        return new Battle(party, new PokemonParty(pokemon));
    }

    public IBattle StartWildBattle(IPokemonParty party, string name, int level)
    {
        return new Battle(party, new PokemonParty(Pokemon.GetPokemon(name, level)));
    }

    public IBattle StartWildBattle(IPokemonParty party, string name, int level, Weather weather)
    {
        return new Battle(party, new PokemonParty(Pokemon.GetPokemon(name, level)), weather: weather);
    }
}