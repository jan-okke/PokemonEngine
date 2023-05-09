using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Sniper : Ability
{
	public override string Name => "Sniper";
	public override string Description => "Powers up moves if they become critical hits.";
}