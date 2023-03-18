using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Milcery : Pokemon
	{
		public override string Name => "Milcery";
		public override List<Ability> AvailableAbilities => new() {new Sweetveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aromaveil() };
		public override Stats BaseStats => new Stats(45, 40, 40, 50, 61, 34);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Aromaticmist() },
			[5] = new List<Move>() { new Sweetkiss() },
			[10] = new List<Move>() { new Sweetscent() },
			[15] = new List<Move>() { new Drainingkiss() },
			[20] = new List<Move>() { new Aromatherapy() },
			[25] = new List<Move>() { new Attract() },
			[30] = new List<Move>() { new Acidarmor() },
			[35] = new List<Move>() { new Dazzlinggleam() },
			[40] = new List<Move>() { new Recover() },
			[45] = new List<Move>() { new Mistyterrain() },
			[50] = new List<Move>() { new Entrainment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Facade(), new Fling(), new Helpinghand(), new Hiddenpower(), new Mistyterrain(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Babydolleyes(), new Lastresort() };
		public override int Weight => 3;
		public override int ExpYield => 54;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}