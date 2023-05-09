using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Normalize : Ability
{
	public override string Name => "Normalize";
	public override string Description => "All the Pokémon's moves become the Normal type.";
}