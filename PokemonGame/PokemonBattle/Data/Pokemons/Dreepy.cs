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
		public override List<Ability> AvailableAbilities => new() {new Clearbody(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cursedbody() };
		public override Stats BaseStats => new Stats(28, 60, 30, 82, 40, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Infestation(), new Quickattack(), new Bite() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Dracometeor(), new Endure(), new Facade(), new Helpinghand(), new Hiddenpower(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Swift(), new Thunderwave() };
		public override List<Move> EggMoves => new List<Move>() { new Confuseray(), new Curse(), new Disable(), new Doubleteam(), new Dragontail(), new Grudge(), new Suckerpunch() };
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