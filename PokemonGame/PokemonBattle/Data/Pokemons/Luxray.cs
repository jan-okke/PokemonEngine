using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Luxray : Pokemon
	{
		public override string Name => "Luxray";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Rivalry(), new Abilities.Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Guts() };
		public override Stats BaseStats => new Stats(80, 120, 79, 95, 79, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Electricterrain(), new Moves.Tackle(), new Moves.Leer(), new Moves.Thundershock(), new Moves.Charge() },
			[12] = new List<Move>() { new Moves.Bite() },
			[18] = new List<Move>() { new Moves.Spark() },
			[24] = new List<Move>() { new Moves.Roar() },
			[33] = new List<Move>() { new Moves.Voltswitch() },
			[40] = new List<Move>() { new Moves.Scaryface() },
			[48] = new List<Move>() { new Moves.Thunderwave() },
			[56] = new List<Move>() { new Moves.Crunch() },
			[64] = new List<Move>() { new Moves.Discharge() },
			[72] = new List<Move>() { new Moves.Swagger() },
			[80] = new List<Move>() { new Moves.Wildcharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firefang(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override int Weight => 420;
		public override int ExpYield => 262;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}