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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterveil(), new Abilities.Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pressure() };
		public override Stats BaseStats => new Stats(170, 90, 45, 90, 45, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Soak(), new Moves.Nobleroar(), new Moves.Splash(), new Moves.Growl(), new Moves.Astonish(), new Moves.Watergun() },
			[15] = new List<Move>() { new Moves.Mist() },
			[18] = new List<Move>() { new Moves.Waterpulse() },
			[21] = new List<Move>() { new Moves.Heavyslam() },
			[24] = new List<Move>() { new Moves.Brine() },
			[27] = new List<Move>() { new Moves.Whirlpool() },
			[30] = new List<Move>() { new Moves.Dive() },
			[33] = new List<Move>() { new Moves.Bounce() },
			[36] = new List<Move>() { new Moves.Bodyslam() },
			[39] = new List<Move>() { new Moves.Rest() },
			[44] = new List<Move>() { new Moves.Amnesia() },
			[49] = new List<Move>() { new Moves.Hydropump() },
			[54] = new List<Move>() { new Moves.Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
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