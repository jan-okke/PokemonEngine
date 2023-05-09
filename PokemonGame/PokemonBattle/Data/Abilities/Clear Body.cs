using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Clearbody : Ability
{
	public override string Name => "Clear Body";
	public override string Description => "Prevents other Pokémon from lowering its stats.";
}