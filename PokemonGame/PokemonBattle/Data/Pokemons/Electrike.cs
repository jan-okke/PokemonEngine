using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Electrike : Pokemon
	{
		public override string Name => "Electrike";
		public override List<Ability> AvailableAbilities => new() {new Static(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Minus() };
		public override Stats BaseStats => new Stats(40, 45, 40, 65, 65, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Thunderwave() },
			[4] = new List<Move>() { new Leer() },
			[8] = new List<Move>() { new Howl() },
			[12] = new List<Move>() { new Quickattack() },
			[16] = new List<Move>() { new Shockwave() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Thunderfang() },
			[28] = new List<Move>() { new Roar() },
			[32] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Charge() },
			[40] = new List<Move>() { new Wildcharge() },
			[44] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Chargebeam(), new Crunch(), new Doubleteam(), new Eerieimpulse(), new Electroball(), new Endure(), new Facade(), new Firefang(), new Flamethrower(), new Flash(), new Hiddenpower(), new Icefang(), new Irontail(), new Lightscreen(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Risingvoltage(), new Roar(), new Round(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Crunch(), new Curse(), new Discharge(), new Eerieimpulse(), new Electroball(), new Firefang(), new Headbutt(), new Icefang(), new Spark(), new Swift(), new Switcheroo(), new Thunderfang(), new Uproar() };
		public override int Weight => 152;
		public override int ExpYield => 59;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}