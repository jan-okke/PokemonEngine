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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
		public override Stats BaseStats => new Stats(68, 72, 78, 38, 42, 32);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Sandattack() },
			[4] = new List<Move>() { new Moves.Bite() },
			[8] = new List<Move>() { new Moves.Yawn() },
			[12] = new List<Move>() { new Moves.Sandtomb() },
			[16] = new List<Move>() { new Moves.Dig() },
			[20] = new List<Move>() { new Moves.Crunch() },
			[24] = new List<Move>() { new Moves.Sandstorm() },
			[28] = new List<Move>() { new Moves.Takedown() },
			[32] = new List<Move>() { new Moves.Roar() },
			[36] = new List<Move>() { new Moves.Rest() },
			[40] = new List<Move>() { new Moves.Earthquake() },
			[44] = new List<Move>() { new Moves.Doubleedge() },
			[48] = new List<Move>() { new Moves.Fissure() },
			[52] = new List<Move>() { new Moves.Slackoff() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Waterpulse(), new Moves.Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Curse(), new Moves.Revenge(), new Moves.Sandtomb(), new Moves.Slackoff(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Whirlwind() };
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