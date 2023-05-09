using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Klutz : Ability
{
	public override string Name => "Klutz";
	public override string Description => "The Pokémon can't use any held items.";
}