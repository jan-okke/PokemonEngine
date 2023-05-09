using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Defiant : Ability
{
	public override string Name => "Defiant";
	public override string Description => "When its stats are lowered its Attack increases.";
}