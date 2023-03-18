using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Boltund : Pokemon
	{
		public override string Name => "Boltund";
		public override List<Ability> AvailableAbilities => new() {new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Competitive() };
		public override Stats BaseStats => new Stats(69, 90, 60, 121, 90, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Electrify(), new Tackle(), new Tailwhip(), new Nuzzle(), new Bite() },
			[15] = new List<Move>() { new Roar() },
			[20] = new List<Move>() { new Spark() },
			[28] = new List<Move>() { new Charm() },
			[34] = new List<Move>() { new Crunch() },
			[41] = new List<Move>() { new Charge() },
			[48] = new List<Move>() { new Wildcharge() },
			[55] = new List<Move>() { new Playrough() },
			[62] = new List<Move>() { new Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bulkup(), new Charm(), new Crunch(), new Dig(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Endure(), new Facade(), new Firefang(), new Focusenergy(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Playrough(), new Protect(), new Psychicfangs(), new Rest(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 340;
		public override int ExpYield => 172;
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