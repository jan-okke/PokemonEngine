using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Raikou : Pokemon
	{
		public override string Name => "Raikou";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(90, 85, 75, 115, 115, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Extremespeed(), new Thundershock(), new Leer(), new Charge(), new Quickattack() },
			[6] = new List<Move>() { new Spark() },
			[12] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Calmmind() },
			[24] = new List<Move>() { new Roar() },
			[30] = new List<Move>() { new Thunderfang() },
			[36] = new List<Move>() { new Howl() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Extrasensory() },
			[54] = new List<Move>() { new Discharge() },
			[60] = new List<Move>() { new Reflect() },
			[66] = new List<Move>() { new Raindance() },
			[72] = new List<Move>() { new Thunder() },
			[78] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Aurasphere(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Eerieimpulse(), new Electricterrain(), new Endure(), new Facade(), new Flash(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Lightscreen(), new Protect(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Risingvoltage(), new Roar(), new Rockclimb(), new Rocksmash(), new Round(), new Sandstorm(), new Scald(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Voltswitch(), new Weatherball(), new Wildcharge() };
		public override int Weight => 1780;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}