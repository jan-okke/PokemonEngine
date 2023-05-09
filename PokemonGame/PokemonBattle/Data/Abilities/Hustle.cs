using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Hustle : Ability
{
	public override string Name => "Hustle";
	public override string Description => "Boosts the Attack stat, but lowers accuracy.";
}