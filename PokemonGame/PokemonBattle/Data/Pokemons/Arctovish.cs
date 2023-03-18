using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Arctovish : Pokemon
	{
		public override string Name => "Arctovish";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Slushrush() };
		public override Stats BaseStats => new Stats(90, 90, 100, 80, 90, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Watergun() },
			[7] = new List<Move>() { new Protect() },
			[14] = new List<Move>() { new Icywind() },
			[21] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Bite() },
			[35] = new List<Move>() { new Auroraveil() },
			[42] = new List<Move>() { new Freezedry() },
			[49] = new List<Move>() { new Superfang() },
			[56] = new List<Move>() { new Crunch() },
			[63] = new List<Move>() { new Fishiousrend() },
			[70] = new List<Move>() { new Iciclecrash() },
			[77] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Avalanche(), new Blizzard(), new Bodyslam(), new Brine(), new Crunch(), new Dive(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Irondefense(), new Ironhead(), new Liquidation(), new Meteorbeam(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Surf(), new Waterfall(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 1750;
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