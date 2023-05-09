using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Lightningrod : Ability
{
	public override string Name => "Lightning Rod";
	public override string Description => "Draws in all Electric-type moves to up Sp. Attack.";
}