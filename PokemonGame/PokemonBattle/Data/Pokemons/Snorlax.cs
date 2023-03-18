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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Immunity(), new Abilities.Thickfat() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(160, 110, 65, 65, 110, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Recycle(), new Moves.Covet(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Screech(), new Moves.Fling(), new Moves.Metronome(), new Moves.Flail(), new Moves.Lastresort(), new Moves.Lick(), new Moves.Tackle(), new Moves.Defensecurl(), new Moves.Block() },
			[12] = new List<Move>() { new Moves.Yawn() },
			[16] = new List<Move>() { new Moves.Bite() },
			[20] = new List<Move>() { new Moves.Rest(), new Moves.Snore(), new Moves.Sleeptalk() },
			[24] = new List<Move>() { new Moves.Crunch() },
			[28] = new List<Move>() { new Moves.Bodyslam() },
			[32] = new List<Move>() { new Moves.Heavyslam() },
			[36] = new List<Move>() { new Moves.Amnesia() },
			[40] = new List<Move>() { new Moves.Highhorsepower() },
			[44] = new List<Move>() { new Moves.Hammerarm() },
			[48] = new List<Move>() { new Moves.Bellydrum() },
			[52] = new List<Move>() { new Moves.Belch() },
			[56] = new List<Move>() { new Moves.Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Outrage(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Terrainpulse(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Belch(), new Moves.Charm(), new Moves.Counter(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Gastroacid(), new Moves.Lick(), new Moves.Poweruppunch(), new Moves.Whirlwind() };
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