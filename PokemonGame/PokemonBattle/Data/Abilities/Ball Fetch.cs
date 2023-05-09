using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Ballfetch : Ability
{
	public override string Name => "Ball Fetch";
	public override string Description => "Retrieves the first thrown Poké Ball if it failed.";
}