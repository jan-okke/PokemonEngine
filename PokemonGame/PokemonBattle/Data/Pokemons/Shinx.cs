using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shinx : Pokemon
	{
		public override string Name => "Shinx";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Guts() };
		public override Stats BaseStats => new Stats(45, 65, 34, 40, 34, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Thundershock() },
			[8] = new List<Move>() { new Charge() },
			[12] = new List<Move>() { new Bite() },
			[16] = new List<Move>() { new Spark() },
			[20] = new List<Move>() { new Roar() },
			[24] = new List<Move>() { new Voltswitch() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Thunderwave() },
			[36] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Discharge() },
			[44] = new List<Move>() { new Swagger() },
			[48] = new List<Move>() { new Wildcharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Chargebeam(), new Crunch(), new Doubleteam(), new Eerieimpulse(), new Electroball(), new Endure(), new Facade(), new Faketears(), new Firefang(), new Flash(), new Helpinghand(), new Hiddenpower(), new Icefang(), new Irontail(), new Lightscreen(), new Playrough(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Risingvoltage(), new Roar(), new Round(), new Scaryface(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Babydolleyes(), new Doublekick(), new Eerieimpulse(), new Faketears(), new Firefang(), new Helpinghand(), new Howl(), new Icefang(), new Nightslash(), new Quickattack(), new Swift(), new Takedown(), new Thunderfang() };
		public override int Weight => 95;
		public override int ExpYield => 53;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}