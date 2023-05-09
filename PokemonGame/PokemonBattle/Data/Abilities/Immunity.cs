using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Immunity : Ability
{
	public override string Name => "Immunity";
	public override string Description => "Prevents the Pokémon from getting poisoned.";
}