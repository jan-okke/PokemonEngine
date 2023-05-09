using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Triage : Ability
{
	public override string Name => "Triage";
	public override string Description => "Gives priority to a healing move.";
}