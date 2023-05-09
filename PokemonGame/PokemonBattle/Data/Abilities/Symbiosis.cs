using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Symbiosis : Ability
{
	public override string Name => "Symbiosis";
	public override string Description => "Passes its held item to an ally that has used theirs.";
}