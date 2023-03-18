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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Weakarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
		public override Stats BaseStats => new Stats(55, 75, 85, 25, 25, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sandattack(), new Moves.Tackle() },
			[4] = new List<Move>() { new Moves.Harden() },
			[8] = new List<Move>() { new Moves.Stealthrock() },
			[12] = new List<Move>() { new Moves.Mudslap() },
			[16] = new List<Move>() { new Moves.Smackdown() },
			[20] = new List<Move>() { new Moves.Irondefense() },
			[24] = new List<Move>() { new Moves.Headbutt() },
			[28] = new List<Move>() { new Moves.Rockslide() },
			[32] = new List<Move>() { new Moves.Rockblast() },
			[36] = new List<Move>() { new Moves.Sandstorm() },
			[40] = new List<Move>() { new Moves.Stoneedge() },
			[44] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Autotomize(), new Moves.Curse(), new Moves.Gravity(), new Moves.Takedown(), new Moves.Wideguard() };
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