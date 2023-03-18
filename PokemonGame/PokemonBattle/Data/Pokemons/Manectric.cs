using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Manectric : Pokemon
	{
		public override string Name => "Manectric";
		public override List<Ability> AvailableAbilities => new() {new Static(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Minus() };
		public override Stats BaseStats => new Stats(70, 75, 60, 105, 105, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Firefang(), new Tackle(), new Thunderwave(), new Leer(), new Howl() },
			[12] = new List<Move>() { new Quickattack() },
			[16] = new List<Move>() { new Shockwave() },
			[20] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Thunderfang() },
			[30] = new List<Move>() { new Roar() },
			[36] = new List<Move>() { new Discharge() },
			[42] = new List<Move>() { new Charge() },
			[48] = new List<Move>() { new Wildcharge() },
			[54] = new List<Move>() { new Thunder() },
			[60] = new List<Move>() { new Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Chargebeam(), new Crunch(), new Doubleteam(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Endure(), new Facade(), new Firefang(), new Flamethrower(), new Flash(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icefang(), new Irontail(), new Lightscreen(), new Overheat(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Risingvoltage(), new Roar(), new Round(), new Scaryface(), new Shockwave(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 402;
		public override int ExpYield => 166;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}