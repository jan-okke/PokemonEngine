using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hippowdon : Pokemon
	{
		public override string Name => "Hippowdon";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
		public override Stats BaseStats => new Stats(108, 112, 118, 68, 72, 47);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Icefang(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Tackle(), new Moves.Sandattack(), new Moves.Bite(), new Moves.Yawn() },
			[12] = new List<Move>() { new Moves.Sandtomb() },
			[16] = new List<Move>() { new Moves.Dig() },
			[20] = new List<Move>() { new Moves.Crunch() },
			[24] = new List<Move>() { new Moves.Sandstorm() },
			[28] = new List<Move>() { new Moves.Takedown() },
			[32] = new List<Move>() { new Moves.Roar() },
			[38] = new List<Move>() { new Moves.Rest() },
			[44] = new List<Move>() { new Moves.Earthquake() },
			[50] = new List<Move>() { new Moves.Doubleedge() },
			[56] = new List<Move>() { new Moves.Fissure() },
			[62] = new List<Move>() { new Moves.Slackoff() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thunderfang(), new Moves.Waterpulse(), new Moves.Weatherball() };
		public override int Weight => 3000;
		public override int ExpYield => 184;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}