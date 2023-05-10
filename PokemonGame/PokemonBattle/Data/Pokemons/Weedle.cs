using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Weedle : Pokemon
{
	public override string Name => "Weedle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
	public override Stats BaseStats => new Stats(40, 35, 30, 20, 20, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Stringshot() },
		[9] = new List<Move>() { new Moves.Bugbite() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Electroweb() };
	public override int Weight => 32;
	public override int ExpYield => 39;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}