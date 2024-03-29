using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Combee : Pokemon
{
	public override string Name => "Combee";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Honeygather() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(30, 30, 42, 30, 42, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sweetscent(), new Moves.Gust(), new Moves.Strugglebug(), new Moves.Bugbite() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbuzz(), new Moves.Dualwingbeat(), new Moves.Snore() };
	public override int Weight => 55;
	public override int ExpYield => 49;
	public override int CatchRate => 120;
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