using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Battlebond : Ability
{
	public override string Name => "Battle Bond";
	public override string Description => "Defeating a foe lets it become Ash-Greninja.";
}