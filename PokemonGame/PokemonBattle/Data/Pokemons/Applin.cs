using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Applin : Pokemon
	{
		public override string Name => "Applin";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Ripen(), new Abilities.Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bulletproof() };
		public override Stats BaseStats => new Stats(40, 40, 80, 40, 40, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Withdraw(), new Moves.Astonish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Dracometeor(), new Moves.Grassyglide(), new Moves.Hiddenpower() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Recycle(), new Moves.Rollout(), new Moves.Suckerpunch() };
		public override int Weight => 5;
		public override int ExpYield => 52;
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