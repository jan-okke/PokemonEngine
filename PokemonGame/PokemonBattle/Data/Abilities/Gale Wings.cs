using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Galewings : Ability
{
	public override string Name => "Gale Wings";
	public override string Description => "Flying-type moves gain priority when its HP is full.";
}