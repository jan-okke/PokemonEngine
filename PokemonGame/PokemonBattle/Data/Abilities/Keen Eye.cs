using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Keeneye : Ability
{
	public override string Name => "Keen Eye";
	public override string Description => "Prevents other Pokémon from lowering accuracy.";
}