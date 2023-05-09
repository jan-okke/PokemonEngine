using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Aurabreak : Ability
{
	public override string Name => "Aura Break";
	public override string Description => "Reverses 'Aura' Abilities to weaken affected moves.";
}