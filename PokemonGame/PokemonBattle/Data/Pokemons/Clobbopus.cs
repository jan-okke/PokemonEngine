using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clobbopus : Pokemon
	{
		public override string Name => "Clobbopus";
		public override List<Ability> AvailableAbilities => new() {new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(50, 68, 60, 50, 50, 32);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rocksmash(), new Leer() },
			[5] = new List<Move>() { new Feint() },
			[10] = new List<Move>() { new Bind() },
			[15] = new List<Move>() { new Detect() },
			[20] = new List<Move>() { new Brickbreak() },
			[25] = new List<Move>() { new Bulkup() },
			[30] = new List<Move>() { new Submission() },
			[35] = new List<Move>() { new Taunt() },
			[40] = new List<Move>() { new Reversal() },
			[45] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Brine(), new Bulkup(), new Closecombat(), new Coaching(), new Dive(), new Endure(), new Facade(), new Focusblast(), new Hiddenpower(), new Icepunch(), new Liquidation(), new Megapunch(), new Muddywater(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Superpower(), new Taunt(), new Waterfall(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Circlethrow(), new Painsplit(), new Poweruppunch(), new Seismictoss(), new Soak(), new Suckerpunch() };
		public override int Weight => 40;
		public override int ExpYield => 62;
		public override int CatchRate => 180;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}