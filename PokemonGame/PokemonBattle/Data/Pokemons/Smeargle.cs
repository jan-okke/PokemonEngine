using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Smeargle : Pokemon
{
	public override string Name => "Smeargle";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
	public override Stats BaseStats => new Stats(55, 20, 35, 20, 45, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sketch() },
		[11] = new List<Move>() { new Moves.Sketch() },
		[21] = new List<Move>() { new Moves.Sketch() },
		[31] = new List<Move>() { new Moves.Sketch() },
		[41] = new List<Move>() { new Moves.Sketch() },
		[51] = new List<Move>() { new Moves.Sketch() },
		[61] = new List<Move>() { new Moves.Sketch() },
		[71] = new List<Move>() { new Moves.Sketch() },
		[81] = new List<Move>() { new Moves.Sketch() },
		[91] = new List<Move>() { new Moves.Sketch() },
	};
	public override int Weight => 580;
	public override int ExpYield => 88;
	public override int CatchRate => 45;
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