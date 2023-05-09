using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Stall : Ability
{
	public override string Name => "Stall";
	public override string Description => "The Pokémon moves after all other Pokémon do.";
}