using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lanturn : Pokemon
	{
		public override string Name => "Lanturn";
		public override List<Ability> AvailableAbilities => new() {new Voltabsorb(), new Illuminate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterabsorb() };
		public override Stats BaseStats => new Stats(125, 58, 58, 76, 76, 67);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[1] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup(), new Eerieimpulse(), new Watergun(), new Supersonic(), new Electroball(), new Thunderwave() },
			[12] = new List<Move>() { new Bubblebeam() },
			[16] = new List<Move>() { new Confuseray() },
			[20] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Charge() },
			[30] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Aquaring() },
			[42] = new List<Move>() { new Flail() },
			[48] = new List<Move>() { new Takedown() },
			[54] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Amnesia(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Chargebeam(), new Dazzlinggleam(), new Dive(), new Doubleteam(), new Eerieimpulse(), new Electroball(), new Endure(), new Facade(), new Flash(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Scald(), new Screech(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wildcharge() };
		public override int Weight => 225;
		public override int ExpYield => 161;
		public override int CatchRate => 75;
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