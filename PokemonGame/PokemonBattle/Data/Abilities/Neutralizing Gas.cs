using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Neutralizinggas : Ability
{
	public override string Name => "Neutralizing Gas";
	public override string Description => "Nullifies the effects of all other Abilities.";
}