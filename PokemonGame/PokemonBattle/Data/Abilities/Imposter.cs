using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Imposter : Ability
{
	public override string Name => "Imposter";
	public override string Description => "It transforms itself into the Pokémon it is facing.";
}