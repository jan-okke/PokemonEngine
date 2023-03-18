using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blastoise : Pokemon
	{
		public override string Name => "Blastoise";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Raindish() };
		public override Stats BaseStats => new Stats(79, 83, 100, 78, 85, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Flashcannon() },
			[1] = new List<Move>() { new Flashcannon(), new Tackle(), new Tailwhip(), new Watergun(), new Withdraw() },
			[9] = new List<Move>() { new Rapidspin() },
			[12] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Protect() },
			[25] = new List<Move>() { new Raindance() },
			[30] = new List<Move>() { new Aquatail() },
			[35] = new List<Move>() { new Shellsmash() },
			[42] = new List<Move>() { new Irondefense() },
			[49] = new List<Move>() { new Hydropump() },
			[56] = new List<Move>() { new Skullbash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Brine(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dig(), new Dive(), new Doubleteam(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Fling(), new Flipturn(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Gyroball(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydrocannon(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irondefense(), new Irontail(), new Liquidation(), new Megakick(), new Megapunch(), new Muddywater(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Terrainpulse(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Workup(), new Zenheadbutt() };
		public override int Weight => 855;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}