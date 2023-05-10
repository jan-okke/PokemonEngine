using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Ballfetch : Ability
{
	public override string Name => "Ball Fetch";
	public override string Description => "Retrieves the first thrown Poké Ball if it failed.";
}