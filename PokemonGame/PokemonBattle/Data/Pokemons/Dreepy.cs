using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dreepy : Pokemon
	{
		public override string Name => "Dreepy";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody(), new Abilities.Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
		public override Stats BaseStats => new Stats(28, 60, 30, 40, 30, 82);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Astonish(), new Moves.Infestation(), new Moves.Quickattack(), new Moves.Bite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Dracometeor(), new Moves.Endure(), new Moves.Facade(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Confuseray(), new Moves.Curse(), new Moves.Disable(), new Moves.Doubleteam(), new Moves.Dragontail(), new Moves.Grudge(), new Moves.Suckerpunch() };
		public override int Weight => 20;
		public override int ExpYield => 54;
		public override int CatchRate => 45;
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