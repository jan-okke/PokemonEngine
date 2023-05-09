using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Merciless : Ability
{
	public override string Name => "Merciless";
	public override string Description => "Its attacks are critical hits when it is poisoned.";
}