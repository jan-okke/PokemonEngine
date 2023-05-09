using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Adaptability : Ability
{
	public override string Name => "Adaptability";
	public override string Description => "Powers up moves of the same type.";
}