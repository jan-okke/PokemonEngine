using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Silcoon : Pokemon
	{
		public override string Name => "Silcoon";
		public override List<Ability> AvailableAbilities => new() {new Shedskin() };
		public override Stats BaseStats => new Stats(50, 35, 55, 15, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Harden() },
			[1] = new List<Move>() { new Harden() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bugbite(), new Electroweb(), new Irondefense() };
		public override int Weight => 100;
		public override int ExpYield => 72;
		public override int CatchRate => 120;
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