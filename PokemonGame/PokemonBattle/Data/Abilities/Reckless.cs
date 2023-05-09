using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Reckless : Ability
{
	public override string Name => "Reckless";
	public override string Description => "Powers up moves that have recoil damage.";
}