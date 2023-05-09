using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Suctioncups : Ability
{
	public override string Name => "Suction Cups";
	public override string Description => "Negates all moves that force switching out.";
}