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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Arenatrap() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
		public override Stats BaseStats => new Stats(45, 100, 45, 45, 45, 10);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sandattack(), new Moves.Astonish() },
			[4] = new List<Move>() { new Moves.Laserfocus() },
			[8] = new List<Move>() { new Moves.Bite() },
			[12] = new List<Move>() { new Moves.Mudslap() },
			[16] = new List<Move>() { new Moves.Sandtomb() },
			[20] = new List<Move>() { new Moves.Bulldoze() },
			[24] = new List<Move>() { new Moves.Dig() },
			[28] = new List<Move>() { new Moves.Crunch() },
			[32] = new List<Move>() { new Moves.Sandstorm() },
			[36] = new List<Move>() { new Moves.Earthpower() },
			[40] = new List<Move>() { new Moves.Earthquake() },
			[44] = new List<Move>() { new Moves.Superpower() },
			[48] = new List<Move>() { new Moves.Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Earthpower(), new Moves.Feint(), new Moves.Flail(), new Moves.Focusenergy(), new Moves.Furycutter(), new Moves.Gust(), new Moves.Mudshot(), new Moves.Quickattack() };
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