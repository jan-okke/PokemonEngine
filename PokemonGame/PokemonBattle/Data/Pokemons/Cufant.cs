using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cufant : Pokemon
	{
		public override string Name => "Cufant";
		public override List<Ability> AvailableAbilities => new() {new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(72, 80, 49, 40, 40, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Rollout() },
			[10] = new List<Move>() { new Rocksmash() },
			[15] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Stomp() },
			[25] = new List<Move>() { new Irondefense() },
			[30] = new List<Move>() { new Dig() },
			[35] = new List<Move>() { new Strength() },
			[40] = new List<Move>() { new Ironhead() },
			[45] = new List<Move>() { new Playrough() },
			[50] = new List<Move>() { new Highhorsepower() },
			[55] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Dig(), new Earthpower(), new Endure(), new Facade(), new Fling(), new Hiddenpower(), new Highhorsepower(), new Irondefense(), new Ironhead(), new Megakick(), new Mudshot(), new Playrough(), new Powerwhip(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Screech(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Substitute(), new Superpower(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Curse(), new Defensecurl(), new Doubleedge(), new Fissure(), new Slam(), new Swagger(), new Whirlwind() };
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
}