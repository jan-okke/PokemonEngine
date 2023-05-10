using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sizzlipede : Pokemon
{
	public override string Name => "Sizzlipede";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire(), new Abilities.Whitesmoke() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
	public override Stats BaseStats => new Stats(50, 65, 45, 50, 50, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Ember(), new Moves.Smokescreen() },
		[5] = new List<Move>() { new Moves.Wrap() },
		[10] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Flamewheel() },
		[20] = new List<Move>() { new Moves.Bugbite() },
		[25] = new List<Move>() { new Moves.Coil() },
		[30] = new List<Move>() { new Moves.Slam() },
		[35] = new List<Move>() { new Moves.Firespin() },
		[40] = new List<Move>() { new Moves.Crunch() },
		[45] = new List<Move>() { new Moves.Firelash() },
		[50] = new List<Move>() { new Moves.Lunge() },
		[55] = new List<Move>() { new Moves.Burnup() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Crunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Firespin(), new Moves.Heatcrash(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scorchingsands(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Knockoff(), new Moves.Rollout(), new Moves.Strugglebug() };
	public override int Weight => 10;
	public override int ExpYield => 61;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}