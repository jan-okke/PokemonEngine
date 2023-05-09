using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Hypercutter : Ability
{
	public override string Name => "Hyper Cutter";
	public override string Description => "Prevents other Pokémon from lowering Attack stat.";
}