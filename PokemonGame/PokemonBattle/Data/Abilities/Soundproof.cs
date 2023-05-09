using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Soundproof : Ability
{
	public override string Name => "Soundproof";
	public override string Description => "Gives full immunity to all sound-based moves.";
}