using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Wonderguard : Ability
{
	public override string Name => "Wonder Guard";
	public override string Description => "Only super-effective moves will hit.";
}