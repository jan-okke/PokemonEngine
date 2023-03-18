using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Luxio : Pokemon
	{
		public override string Name => "Luxio";
		public override List<Ability> AvailableAbilities => new() {new Rivalry(), new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Guts() };
		public override Stats BaseStats => new Stats(60, 85, 49, 60, 60, 49);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer(), new Thundershock(), new Charge() },
			[12] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Spark() },
			[24] = new List<Move>() { new Roar() },
			[31] = new List<Move>() { new Voltswitch() },
			[36] = new List<Move>() { new Scaryface() },
			[42] = new List<Move>() { new Thunderwave() },
			[48] = new List<Move>() { new Crunch() },
			[54] = new List<Move>() { new Discharge() },
			[60] = new List<Move>() { new Swagger() },
			[68] = new List<Move>() { new Wildcharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Chargebeam(), new Crunch(), new Doubleteam(), new Eerieimpulse(), new Electroball(), new Endure(), new Facade(), new Faketears(), new Firefang(), new Flash(), new Helpinghand(), new Hiddenpower(), new Icefang(), new Irontail(), new Lightscreen(), new Playrough(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Risingvoltage(), new Roar(), new Round(), new Scaryface(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 305;
		public override int ExpYield => 127;
		public override int CatchRate => 120;
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