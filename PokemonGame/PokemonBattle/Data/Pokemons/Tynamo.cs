using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tynamo : Pokemon
	{
		public override string Name => "Tynamo";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(35, 55, 40, 60, 45, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Thunderwave(), new Spark(), new Chargebeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Chargebeam(), new Magnetrise(), new Thunderwave() };
		public override int Weight => 3;
		public override int ExpYield => 55;
		public override int CatchRate => 190;
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