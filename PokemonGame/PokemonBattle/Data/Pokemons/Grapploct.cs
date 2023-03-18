using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grapploct : Pokemon
	{
		public override string Name => "Grapploct";
		public override List<Ability> AvailableAbilities => new() {new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(80, 118, 90, 42, 70, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Octolock() },
			[1] = new List<Move>() { new Octolock(), new Octazooka(), new Rocksmash(), new Leer(), new Feint(), new Bind() },
			[15] = new List<Move>() { new Detect() },
			[20] = new List<Move>() { new Brickbreak() },
			[25] = new List<Move>() { new Bulkup() },
			[30] = new List<Move>() { new Submission() },
			[35] = new List<Move>() { new Taunt() },
			[40] = new List<Move>() { new Reversal() },
			[45] = new List<Move>() { new Superpower() },
			[50] = new List<Move>() { new Topsyturvy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Brine(), new Brutalswing(), new Bulkup(), new Closecombat(), new Coaching(), new Dig(), new Dive(), new Drainpunch(), new Endure(), new Facade(), new Focusblast(), new Gigaimpact(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icepunch(), new Liquidation(), new Megapunch(), new Muddywater(), new Mudshot(), new Payback(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Skittersmack(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superpower(), new Surf(), new Taunt(), new Waterfall(), new Whirlpool(), new Workup() };
		public override int Weight => 390;
		public override int ExpYield => 168;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}