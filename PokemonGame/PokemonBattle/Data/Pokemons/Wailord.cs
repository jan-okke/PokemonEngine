using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wailord : Pokemon
	{
		public override string Name => "Wailord";
		public override List<Ability> AvailableAbilities => new() {new Waterveil(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(170, 90, 45, 90, 45, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Soak(), new Nobleroar(), new Splash(), new Growl(), new Astonish(), new Watergun() },
			[15] = new List<Move>() { new Mist() },
			[18] = new List<Move>() { new Waterpulse() },
			[21] = new List<Move>() { new Heavyslam() },
			[24] = new List<Move>() { new Brine() },
			[27] = new List<Move>() { new Whirlpool() },
			[30] = new List<Move>() { new Dive() },
			[33] = new List<Move>() { new Bounce() },
			[36] = new List<Move>() { new Bodyslam() },
			[39] = new List<Move>() { new Rest() },
			[44] = new List<Move>() { new Amnesia() },
			[49] = new List<Move>() { new Hydropump() },
			[54] = new List<Move>() { new Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bounce(), new Brine(), new Bulldoze(), new Dive(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Ironhead(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 3980;
		public override int ExpYield => 175;
		public override int CatchRate => 60;
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