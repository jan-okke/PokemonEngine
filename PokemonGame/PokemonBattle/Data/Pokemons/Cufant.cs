using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cufant : Pokemon
{
	public override string Name => "Cufant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
	public override Stats BaseStats => new Stats(72, 80, 49, 40, 49, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[5] = new List<Move>() { new Moves.Rollout() },
		[10] = new List<Move>() { new Moves.Rocksmash() },
		[15] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Stomp() },
		[25] = new List<Move>() { new Moves.Irondefense() },
		[30] = new List<Move>() { new Moves.Dig() },
		[35] = new List<Move>() { new Moves.Strength() },
		[40] = new List<Move>() { new Moves.Ironhead() },
		[45] = new List<Move>() { new Moves.Playrough() },
		[50] = new List<Move>() { new Moves.Highhorsepower() },
		[55] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Mudshot(), new Moves.Playrough(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Curse(), new Moves.Defensecurl(), new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Slam(), new Moves.Swagger(), new Moves.Whirlwind() };
	public override int Weight => 1000;
	public override int ExpYield => 66;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}