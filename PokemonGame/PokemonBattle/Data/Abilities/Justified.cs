using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Justified : Ability
{
	public override string Name => "Justified";
	public override string Description => "Raises Attack when hit by a Dark-type move.";
}