using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Angerpoint : Ability
{
	public override string Name => "Anger Point";
	public override string Description => "Maxes Attack after taking a critical hit.";
}