using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Berserk : Ability
{
	public override string Name => "Berserk";
	public override string Description => "Ups Sp. Atk if a hit makes its HP half or less.";
}