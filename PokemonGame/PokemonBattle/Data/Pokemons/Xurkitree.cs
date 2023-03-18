using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Xurkitree : Pokemon
	{
		public override string Name => "Xurkitree";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(83, 89, 71, 173, 71, 83);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Thundershock() },
			[5] = new List<Move>() { new Charge() },
			[10] = new List<Move>() { new Thunderwave() },
			[15] = new List<Move>() { new Ingrain() },
			[20] = new List<Move>() { new Spark() },
			[25] = new List<Move>() { new Shockwave() },
			[30] = new List<Move>() { new Hypnosis() },
			[35] = new List<Move>() { new Eerieimpulse() },
			[40] = new List<Move>() { new Thunderpunch() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Magnetrise() },
			[55] = new List<Move>() { new Thunderbolt() },
			[60] = new List<Move>() { new Electricterrain() },
			[65] = new List<Move>() { new Powerwhip() },
			[70] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Brutalswing(), new Calmmind(), new Dazzlinggleam(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Powerwhip(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 1000;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}