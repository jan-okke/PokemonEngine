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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Static(), new Abilities.Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Minus() };
		public override Stats BaseStats => new Stats(40, 45, 40, 65, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Thunderwave() },
			[4] = new List<Move>() { new Moves.Leer() },
			[8] = new List<Move>() { new Moves.Howl() },
			[12] = new List<Move>() { new Moves.Quickattack() },
			[16] = new List<Move>() { new Moves.Shockwave() },
			[20] = new List<Move>() { new Moves.Bite() },
			[24] = new List<Move>() { new Moves.Thunderfang() },
			[28] = new List<Move>() { new Moves.Roar() },
			[32] = new List<Move>() { new Moves.Discharge() },
			[36] = new List<Move>() { new Moves.Charge() },
			[40] = new List<Move>() { new Moves.Wildcharge() },
			[44] = new List<Move>() { new Moves.Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Hiddenpower(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Round(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Crunch(), new Moves.Curse(), new Moves.Discharge(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Firefang(), new Moves.Headbutt(), new Moves.Icefang(), new Moves.Spark(), new Moves.Swift(), new Moves.Switcheroo(), new Moves.Thunderfang(), new Moves.Uproar() };
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