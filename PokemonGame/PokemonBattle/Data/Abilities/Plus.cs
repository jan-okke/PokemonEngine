using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Plus : Ability
{
	public override string Name => "Plus";
	public override string Description => "Ups Sp. Atk if another Pokémon has Plus or Minus.";
}