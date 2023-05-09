using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Steadfast : Ability
{
	public override string Name => "Steadfast";
	public override string Description => "Raises Speed each time the Pokémon flinches.";
}