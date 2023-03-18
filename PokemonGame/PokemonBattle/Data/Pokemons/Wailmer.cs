using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wailmer : Pokemon
	{
		public override string Name => "Wailmer";
		public override List<Ability> AvailableAbilities => new() {new Waterveil(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(130, 70, 35, 60, 70, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash() },
			[3] = new List<Move>() { new Growl() },
			[6] = new List<Move>() { new Astonish() },
			[12] = new List<Move>() { new Watergun() },
			[15] = new List<Move>() { new Mist() },
			[18] = new List<Move>() { new Waterpulse() },
			[21] = new List<Move>() { new Heavyslam() },
			[24] = new List<Move>() { new Brine() },
			[27] = new List<Move>() { new Whirlpool() },
			[30] = new List<Move>() { new Dive() },
			[33] = new List<Move>() { new Bounce() },
			[36] = new List<Move>() { new Bodyslam() },
			[39] = new List<Move>() { new Rest() },
			[42] = new List<Move>() { new Amnesia() },
			[45] = new List<Move>() { new Hydropump() },
			[48] = new List<Move>() { new Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bounce(), new Brine(), new Bulldoze(), new Dive(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icebeam(), new Icywind(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Bodyslam(), new Clearsmog(), new Curse(), new Defensecurl(), new Doubleedge(), new Fissure(), new Rollout(), new Snore(), new Soak(), new Thrash(), new Tickle(), new Zenheadbutt() };
		public override int Weight => 1300;
		public override int ExpYield => 80;
		public override int CatchRate => 125;
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