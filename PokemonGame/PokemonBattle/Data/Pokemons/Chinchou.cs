using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chinchou : Pokemon
	{
		public override string Name => "Chinchou";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb(), new Illuminate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(75, 38, 38, 56, 56, 67);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Supersonic() },
			[4] = new List<Move>() { new Electroball() },
			[8] = new List<Move>() { new Thunderwave() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Confuseray() },
			[20] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Charge() },
			[28] = new List<Move>() { new Discharge() },
			[32] = new List<Move>() { new Aquaring() },
			[36] = new List<Move>() { new Flail() },
			[40] = new List<Move>() { new Takedown() },
			[44] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Amnesia(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Chargebeam(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Electroball(), new Endure(), new Facade(), new Flash(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Scald(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Amnesia(), new Flail(), new Mist(), new Psybeam(), new Screech(), new Soak(), new Whirlpool() };
		public override int Weight => 120;
		public override int ExpYield => 66;
		public override int CatchRate => 190;
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