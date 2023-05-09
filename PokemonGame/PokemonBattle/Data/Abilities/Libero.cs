using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Libero : Ability
{
	public override string Name => "Libero";
	public override string Description => "It changes type to that of the move it's about to use.";
}