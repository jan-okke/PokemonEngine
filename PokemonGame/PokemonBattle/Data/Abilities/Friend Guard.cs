using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Friendguard : Ability
{
	public override string Name => "Friend Guard";
	public override string Description => "Reduces damage done to allies.";
}