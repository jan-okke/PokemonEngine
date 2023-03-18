using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Trapinch : Pokemon
	{
		public override string Name => "Trapinch";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Arenatrap() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(45, 100, 45, 10, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandattack(), new Astonish() },
			[4] = new List<Move>() { new Laserfocus() },
			[8] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Sandtomb() },
			[20] = new List<Move>() { new Bulldoze() },
			[24] = new List<Move>() { new Dig() },
			[28] = new List<Move>() { new Crunch() },
			[32] = new List<Move>() { new Sandstorm() },
			[36] = new List<Move>() { new Earthpower() },
			[40] = new List<Move>() { new Earthquake() },
			[44] = new List<Move>() { new Superpower() },
			[48] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulldoze(), new Crunch(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Focusenergy(), new Gigadrain(), new Hiddenpower(), new Hyperbeam(), new Mudshot(), new Protect(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scorchingsands(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Earthpower(), new Feint(), new Flail(), new Focusenergy(), new Furycutter(), new Gust(), new Mudshot(), new Quickattack() };
		public override int Weight => 150;
		public override int ExpYield => 58;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}