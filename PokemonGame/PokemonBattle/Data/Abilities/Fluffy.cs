using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Fluffy : Ability
{
	public override string Name => "Fluffy";
	public override string Description => "Resists contact damage but weaker to Fire-type.";
}