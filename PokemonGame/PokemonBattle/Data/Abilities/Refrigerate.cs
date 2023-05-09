using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Refrigerate : Ability
{
	public override string Name => "Refrigerate";
	public override string Description => "Normal-type moves become Ice-type and powered up.";
}