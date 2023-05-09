using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Beastboost : Ability
{
	public override string Name => "Beast Boost";
	public override string Description => "Boosts its best stat each time it deals a KO.";
}