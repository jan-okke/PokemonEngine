using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Stakeout : Ability
{
	public override string Name => "Stakeout";
	public override string Description => "Deals doubles damage to a target's replacement.";
}