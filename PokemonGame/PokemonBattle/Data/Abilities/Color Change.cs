using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Colorchange : Ability
{
	public override string Name => "Color Change";
	public override string Description => "Changes the Pokémon's type to the foe's move.";
}