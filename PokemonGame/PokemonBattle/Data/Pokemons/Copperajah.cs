using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Copperajah : Pokemon
	{
		public override string Name => "Copperajah";
		public override List<Ability> AvailableAbilities => new() {new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Heavymetal() };
		public override Stats BaseStats => new Stats(122, 130, 69, 80, 69, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Heavyslam() },
			[1] = new List<Move>() { new Heavyslam(), new Tackle(), new Growl(), new Rollout(), new Rocksmash() },
			[15] = new List<Move>() { new Bulldoze() },
			[20] = new List<Move>() { new Stomp() },
			[25] = new List<Move>() { new Irondefense() },
			[30] = new List<Move>() { new Dig() },
			[37] = new List<Move>() { new Strength() },
			[44] = new List<Move>() { new Ironhead() },
			[51] = new List<Move>() { new Playrough() },
			[58] = new List<Move>() { new Highhorsepower() },
			[65] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Dig(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Gigaimpact(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Megakick(), new Mudshot(), new Outrage(), new Payback(), new Playrough(), new Powerwhip(), new Protect(), new Rest(), new Revenge(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snarl(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Taunt(), new Workup(), new Zenheadbutt() };
		public override int Weight => 6500;
		public override int ExpYield => 175;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}