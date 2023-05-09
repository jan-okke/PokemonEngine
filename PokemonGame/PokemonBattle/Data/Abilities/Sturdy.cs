using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Sturdy : Ability
{
	public override string Name => "Sturdy";
	public override string Description => "It cannot be knocked out with one hit.";
}