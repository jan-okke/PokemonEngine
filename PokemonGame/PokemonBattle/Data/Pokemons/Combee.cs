using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Combee : Pokemon
	{
		public override string Name => "Combee";
		public override List<Ability> AvailableAbilities => new() {new Honeygather() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(30, 30, 42, 70, 30, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sweetscent(), new Gust(), new Strugglebug(), new Bugbite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bugbuzz(), new Dualwingbeat(), new Snore() };
		public override int Weight => 55;
		public override int ExpYield => 49;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}