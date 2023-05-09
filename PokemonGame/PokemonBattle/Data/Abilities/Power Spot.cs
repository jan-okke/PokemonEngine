using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Powerspot : Ability
{
	public override string Name => "Power Spot";
	public override string Description => "Just being next to the Pokémon powers up moves.";
}