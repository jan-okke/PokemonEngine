using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Battery : Ability
{
	public override string Name => "Battery";
	public override string Description => "Powers up ally Pokémon's special moves.";
}