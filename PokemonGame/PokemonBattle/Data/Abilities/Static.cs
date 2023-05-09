using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Static : Ability
{
	public override string Name => "Static";
	public override string Description => "Contact with the Pokémon may cause paralysis.";
}