using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hippopotas : Pokemon
	{
		public override string Name => "Hippopotas";
		public override List<Ability> AvailableAbilities => new() {new Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(68, 72, 78, 32, 38, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Sandattack() },
			[4] = new List<Move>() { new Bite() },
			[8] = new List<Move>() { new Yawn() },
			[12] = new List<Move>() { new Sandtomb() },
			[16] = new List<Move>() { new Dig() },
			[20] = new List<Move>() { new Crunch() },
			[24] = new List<Move>() { new Sandstorm() },
			[28] = new List<Move>() { new Takedown() },
			[32] = new List<Move>() { new Roar() },
			[36] = new List<Move>() { new Rest() },
			[40] = new List<Move>() { new Earthquake() },
			[44] = new List<Move>() { new Doubleedge() },
			[48] = new List<Move>() { new Fissure() },
			[52] = new List<Move>() { new Slackoff() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Bulldoze(), new Crunch(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Hiddenpower(), new Highhorsepower(), new Irontail(), new Muddywater(), new Mudshot(), new Protect(), new Rest(), new Revenge(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Waterpulse(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Bodyslam(), new Curse(), new Revenge(), new Sandtomb(), new Slackoff(), new Spitup(), new Stockpile(), new Swallow(), new Whirlwind() };
		public override int Weight => 495;
		public override int ExpYield => 66;
		public override int CatchRate => 140;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}