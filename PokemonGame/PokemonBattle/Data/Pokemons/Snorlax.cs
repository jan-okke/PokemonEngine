using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Snorlax : Pokemon
	{
		public override string Name => "Snorlax";
		public override List<Ability> AvailableAbilities => new() {new Immunity(), new Thickfat() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(160, 110, 65, 65, 110, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Recycle(), new Covet(), new Stockpile(), new Swallow(), new Screech(), new Fling(), new Metronome(), new Flail(), new Lastresort(), new Lick(), new Tackle(), new Defensecurl(), new Block() },
			[12] = new List<Move>() { new Yawn() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Rest(), new Snore(), new Sleeptalk() },
			[24] = new List<Move>() { new Crunch() },
			[28] = new List<Move>() { new Bodyslam() },
			[32] = new List<Move>() { new Heavyslam() },
			[36] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Highhorsepower() },
			[44] = new List<Move>() { new Hammerarm() },
			[48] = new List<Move>() { new Bellydrum() },
			[52] = new List<Move>() { new Belch() },
			[56] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Charm(), new Crunch(), new Darkestlariat(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Gunkshot(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Ironhead(), new Megakick(), new Megapunch(), new Metronome(), new Outrage(), new Payday(), new Protect(), new Psychic(), new Raindance(), new Recycle(), new Rest(), new Retaliate(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Screech(), new Seedbomb(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelroller(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Terrainpulse(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Uproar(), new Waterpulse(), new Whirlpool(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Belch(), new Charm(), new Counter(), new Curse(), new Doubleedge(), new Fissure(), new Gastroacid(), new Lick(), new Poweruppunch(), new Whirlwind() };
		public override int Weight => 4600;
		public override int ExpYield => 189;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}