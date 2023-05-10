using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Truant : Ability
{
	public override string Name => "Truant";
	public override string Description => "Pokémon can't attack on consecutive turns.";
}