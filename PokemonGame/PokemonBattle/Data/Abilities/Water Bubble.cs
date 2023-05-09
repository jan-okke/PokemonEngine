using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Waterbubble : Ability
{
	public override string Name => "Water Bubble";
	public override string Description => "Weakens incoming Fire-type moves and prevents burns.";
}