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
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Sandstream() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(85, 135, 130, 25, 60, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powergem(), new Sandattack(), new Tackle(), new Harden(), new Stealthrock() },
			[12] = new List<Move>() { new Mudslap() },
			[16] = new List<Move>() { new Smackdown() },
			[20] = new List<Move>() { new Irondefense() },
			[24] = new List<Move>() { new Headbutt() },
			[30] = new List<Move>() { new Rockslide() },
			[36] = new List<Move>() { new Rockblast() },
			[42] = new List<Move>() { new Sandstorm() },
			[48] = new List<Move>() { new Stoneedge() },
			[54] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bulldoze(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Meteorbeam(), new Powergem(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Throatchop(), new Weatherball() };
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