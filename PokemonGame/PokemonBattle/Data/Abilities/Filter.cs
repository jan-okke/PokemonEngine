using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Filter : Ability
{
	public override string Name => "Filter";
	public override string Description => "Reduces damage from super-effective attacks.";
}