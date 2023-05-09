using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Technician : Ability
{
	public override string Name => "Technician";
	public override string Description => "Powers up the Pokémon's weaker moves.";
}