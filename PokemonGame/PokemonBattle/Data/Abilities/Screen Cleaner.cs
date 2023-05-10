using PokemonGame.PokemonBattle.Entities;

namespace PokemonGame.PokemonBattle.Data.Abilities;

public class Screencleaner : Ability
{
	public override string Name => "Screen Cleaner";
	public override string Description => "On entering battle, clears effects of Reflect, etc.";
}