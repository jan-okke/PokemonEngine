using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Galvanize : Ability
{
	public override string Name => "Galvanize";
	public override string Description => "Normal-type moves become Electric-type and powered.";
}