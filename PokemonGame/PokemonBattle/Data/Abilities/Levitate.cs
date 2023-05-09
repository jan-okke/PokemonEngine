using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Levitate : Ability
{
	public override string Name => "Levitate";
	public override string Description => "Gives full immunity to all Ground-type moves.";
}