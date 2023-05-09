using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Harvest : Ability
{
	public override string Name => "Harvest";
	public override string Description => "May create another Berry after one is used.";
}