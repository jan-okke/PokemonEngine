using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Solarpower : Ability
{
	public override string Name => "Solar Power";
	public override string Description => "In sunshine, Sp. Atk is boosted but HP decreases.";
}