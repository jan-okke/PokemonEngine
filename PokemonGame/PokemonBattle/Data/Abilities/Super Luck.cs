using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Superluck : Ability
{
	public override string Name => "Super Luck";
	public override string Description => "Heightens the critical-hit ratios of moves.";
}