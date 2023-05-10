using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Poisonheal : Ability
{
	public override string Name => "Poison Heal";
	public override string Description => "Restores HP if the Pokémon is poisoned.";
}