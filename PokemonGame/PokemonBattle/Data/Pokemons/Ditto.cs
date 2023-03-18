using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ditto : Pokemon
	{
		public override string Name => "Ditto";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Imposter() };
		public override Stats BaseStats => new Stats(48, 48, 48, 48, 48, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Transform() },
		};
		public override int Weight => 40;
		public override int ExpYield => 101;
		public override int CatchRate => 35;
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