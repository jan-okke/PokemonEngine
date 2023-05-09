using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Stalwart : Ability
{
	public override string Name => "Stalwart";
	public override string Description => "This Pokémon's moves cannot be redirected.";
}