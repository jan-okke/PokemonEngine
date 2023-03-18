using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gigalith : Pokemon
	{
		public override string Name => "Gigalith";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
		public override Stats BaseStats => new Stats(85, 135, 130, 60, 80, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Powergem(), new Moves.Sandattack(), new Moves.Tackle(), new Moves.Harden(), new Moves.Stealthrock() },
			[12] = new List<Move>() { new Moves.Mudslap() },
			[16] = new List<Move>() { new Moves.Smackdown() },
			[20] = new List<Move>() { new Moves.Irondefense() },
			[24] = new List<Move>() { new Moves.Headbutt() },
			[30] = new List<Move>() { new Moves.Rockslide() },
			[36] = new List<Move>() { new Moves.Rockblast() },
			[42] = new List<Move>() { new Moves.Sandstorm() },
			[48] = new List<Move>() { new Moves.Stoneedge() },
			[54] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Meteorbeam(), new Moves.Powergem(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Throatchop(), new Moves.Weatherball() };
		public override int Weight => 2600;
		public override int ExpYield => 258;
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