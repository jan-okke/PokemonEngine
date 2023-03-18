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
		public override List<Ability> AvailableAbilities => new() {new Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(108, 112, 118, 47, 68, 72);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Icefang(), new Firefang(), new Thunderfang(), new Tackle(), new Sandattack(), new Bite(), new Yawn() },
			[12] = new List<Move>() { new Sandtomb() },
			[16] = new List<Move>() { new Dig() },
			[20] = new List<Move>() { new Crunch() },
			[24] = new List<Move>() { new Sandstorm() },
			[28] = new List<Move>() { new Takedown() },
			[32] = new List<Move>() { new Roar() },
			[38] = new List<Move>() { new Rest() },
			[44] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Doubleedge() },
			[56] = new List<Move>() { new Fissure() },
			[62] = new List<Move>() { new Slackoff() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Crunch(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icefang(), new Ironhead(), new Irontail(), new Muddywater(), new Mudshot(), new Protect(), new Rest(), new Revenge(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thunderfang(), new Waterpulse(), new Weatherball() };
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