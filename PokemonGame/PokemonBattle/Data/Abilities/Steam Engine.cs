using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Steamengine : Ability
{
	public override string Name => "Steam Engine";
	public override string Description => "Boosts Speed drastically if hit by a Fire or Water move.";
}