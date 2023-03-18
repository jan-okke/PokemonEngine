using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Munchlax : Pokemon
	{
		public override string Name => "Munchlax";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Thickfat() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(135, 85, 40, 40, 85, 5);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lick(), new Tackle() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Recycle() },
			[12] = new List<Move>() { new Covet() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Stockpile(), new Swallow() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Bodyslam() },
			[32] = new List<Move>() { new Fling() },
			[36] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Metronome() },
			[44] = new List<Move>() { new Flail() },
			[48] = new List<Move>() { new Bellydrum() },
			[52] = new List<Move>() { new Lastresort() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Charm(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Gunkshot(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Megakick(), new Megapunch(), new Metronome(), new Payday(), new Protect(), new Psychic(), new Raindance(), new Recycle(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Screech(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Waterpulse(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Belch(), new Charm(), new Counter(), new Curse(), new Doubleedge(), new Fissure(), new Lick(), new Selfdestruct(), new Whirlwind(), new Zenheadbutt() };
		public override int Weight => 1050;
		public override int ExpYield => 78;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}