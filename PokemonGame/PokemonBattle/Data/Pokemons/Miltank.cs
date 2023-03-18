using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Miltank : Pokemon
	{
		public override string Name => "Miltank";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Scrappy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(95, 80, 105, 100, 40, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Rollout() },
			[10] = new List<Move>() { new Defensecurl() },
			[15] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Healbell() },
			[25] = new List<Move>() { new Headbutt() },
			[30] = new List<Move>() { new Zenheadbutt() },
			[35] = new List<Move>() { new Milkdrink() },
			[40] = new List<Move>() { new Bodyslam() },
			[45] = new List<Move>() { new Playrough() },
			[50] = new List<Move>() { new Charm() },
			[55] = new List<Move>() { new Highhorsepower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Charm(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Gyroball(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Ironhead(), new Irontail(), new Megakick(), new Megapunch(), new Metronome(), new Playrough(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Retaliate(), new Reversal(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelroller(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Waterpulse(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Curse(), new Doubleedge(), new Hammerarm(), new Helpinghand(), new Present(), new Reversal(), new Seismictoss() };
		public override int Weight => 755;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}