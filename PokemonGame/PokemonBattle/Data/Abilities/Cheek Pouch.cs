using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Cheekpouch : Ability
{
	public override string Name => "Cheek Pouch";
	public override string Description => "Restores HP as well when the Pokémon eats a Berry.";
}