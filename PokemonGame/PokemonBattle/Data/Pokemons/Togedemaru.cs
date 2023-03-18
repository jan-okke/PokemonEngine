using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Togedemaru : Pokemon
	{
		public override string Name => "Togedemaru";
		public override List<Ability> AvailableAbilities => new() {new Ironbarbs(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(65, 98, 63, 96, 40, 73);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nuzzle(), new Tackle() },
			[5] = new List<Move>() { new Defensecurl() },
			[10] = new List<Move>() { new Charge() },
			[15] = new List<Move>() { new Thundershock() },
			[20] = new List<Move>() { new Fellstinger() },
			[25] = new List<Move>() { new Spark() },
			[30] = new List<Move>() { new Pinmissile() },
			[35] = new List<Move>() { new Magnetrise() },
			[40] = new List<Move>() { new Zingzap() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Electricterrain() },
			[55] = new List<Move>() { new Wildcharge() },
			[60] = new List<Move>() { new Spikyshield() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Bounce(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Facade(), new Fling(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Reversal(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelroller(), new Substitute(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uturn(), new Voltswitch(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Disarmingvoice(), new Fakeout(), new Flail(), new Present(), new Tickle(), new Wish() };
		public override int Weight => 33;
		public override int ExpYield => 152;
		public override int CatchRate => 180;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}