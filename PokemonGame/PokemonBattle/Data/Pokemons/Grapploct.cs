using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Grapploct : Pokemon
{
	public override string Name => "Grapploct";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(80, 118, 90, 70, 80, 42);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Octolock() },
		[1] = new List<Move>() { new Moves.Octolock(), new Moves.Octazooka(), new Moves.Rocksmash(), new Moves.Leer(), new Moves.Feint(), new Moves.Bind() },
		[15] = new List<Move>() { new Moves.Detect() },
		[20] = new List<Move>() { new Moves.Brickbreak() },
		[25] = new List<Move>() { new Moves.Bulkup() },
		[30] = new List<Move>() { new Moves.Submission() },
		[35] = new List<Move>() { new Moves.Taunt() },
		[40] = new List<Move>() { new Moves.Reversal() },
		[45] = new List<Move>() { new Moves.Superpower() },
		[50] = new List<Move>() { new Moves.Topsyturvy() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Dive(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Liquidation(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Taunt(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Workup() };
	public override int Weight => 390;
	public override int ExpYield => 168;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}