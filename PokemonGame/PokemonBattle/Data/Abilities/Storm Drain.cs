using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Stormdrain : Ability
{
	public override string Name => "Storm Drain";
	public override string Description => "Draws in all Water-type moves to up Sp. Attack.";
}