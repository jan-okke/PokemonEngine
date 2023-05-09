using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Burmy : Pokemon
{
	public override string Name => "Burmy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(40, 29, 45, 29, 45, 36);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Protect() },
		[10] = new List<Move>() { new Moves.Tackle() },
		[15] = new List<Move>() { new Moves.Bugbite() },
		[20] = new List<Move>() { new Moves.Stringshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Electroweb(), new Moves.Hiddenpower(), new Moves.Protect() };
	public override int Weight => 34;
	public override int ExpYield => 45;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}