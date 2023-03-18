using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wurmple : Pokemon
	{
		public override string Name => "Wurmple";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
		public override Stats BaseStats => new Stats(45, 45, 35, 20, 30, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Stringshot() },
			[5] = new List<Move>() { new Moves.Poisonsting() },
			[15] = new List<Move>() { new Moves.Bugbite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Electroweb(), new Moves.Snore() };
		public override int Weight => 36;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}