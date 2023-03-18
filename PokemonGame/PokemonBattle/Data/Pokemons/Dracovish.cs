using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dracovish : Pokemon
	{
		public override string Name => "Dracovish";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandrush() };
		public override Stats BaseStats => new Stats(90, 90, 100, 75, 70, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Watergun() },
			[7] = new List<Move>() { new Protect() },
			[14] = new List<Move>() { new Brutalswing() },
			[21] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Bite() },
			[35] = new List<Move>() { new Dragonbreath() },
			[42] = new List<Move>() { new Stomp() },
			[49] = new List<Move>() { new Superfang() },
			[56] = new List<Move>() { new Crunch() },
			[63] = new List<Move>() { new Fishiousrend() },
			[70] = new List<Move>() { new Dragonpulse() },
			[77] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Brine(), new Brutalswing(), new Bulldoze(), new Crunch(), new Dive(), new Dracometeor(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icefang(), new Ironhead(), new Leechlife(), new Liquidation(), new Lowkick(), new Megakick(), new Meteorbeam(), new Outrage(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Surf(), new Waterfall(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 2150;
		public override int ExpYield => 177;
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