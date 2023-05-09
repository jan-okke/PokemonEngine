using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Moody : Ability
{
	public override string Name => "Moody";
	public override string Description => "Raises one stat and lowers another.";
}