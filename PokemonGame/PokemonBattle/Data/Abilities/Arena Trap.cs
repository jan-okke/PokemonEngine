using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Arenatrap : Ability
{
	public override string Name => "Arena Trap";
	public override string Description => "Prevents the foe from fleeing.";
}