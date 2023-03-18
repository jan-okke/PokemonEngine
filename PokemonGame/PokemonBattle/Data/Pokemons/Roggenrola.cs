using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Roggenrola : Pokemon
	{
		public override string Name => "Roggenrola";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(55, 75, 85, 25, 25, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandattack(), new Tackle() },
			[4] = new List<Move>() { new Harden() },
			[8] = new List<Move>() { new Stealthrock() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Smackdown() },
			[20] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Headbutt() },
			[28] = new List<Move>() { new Rockslide() },
			[32] = new List<Move>() { new Rockblast() },
			[36] = new List<Move>() { new Sandstorm() },
			[40] = new List<Move>() { new Stoneedge() },
			[44] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Heavyslam(), new Hiddenpower(), new Irondefense(), new Meteorbeam(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Autotomize(), new Curse(), new Gravity(), new Takedown(), new Wideguard() };
		public override int Weight => 180;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
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