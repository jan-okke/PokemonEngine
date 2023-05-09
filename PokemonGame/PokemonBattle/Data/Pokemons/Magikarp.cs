using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Magikarp : Pokemon
{
	public override string Name => "Magikarp";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(20, 10, 55, 15, 20, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash() },
		[15] = new List<Move>() { new Moves.Tackle() },
		[25] = new List<Move>() { new Moves.Flail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bounce(), new Moves.Hydropump() };
	public override int Weight => 100;
	public override int ExpYield => 40;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}