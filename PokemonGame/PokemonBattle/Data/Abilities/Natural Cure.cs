using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Naturalcure : Ability
{
	public override string Name => "Natural Cure";
	public override string Description => "All status problems heal when it switches out.";
}