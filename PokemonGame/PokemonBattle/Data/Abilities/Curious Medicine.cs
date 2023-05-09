using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Curiousmedicine : Ability
{
	public override string Name => "Curious Medicine";
	public override string Description => "Removes all allies' stat changes on joining battle.";
}