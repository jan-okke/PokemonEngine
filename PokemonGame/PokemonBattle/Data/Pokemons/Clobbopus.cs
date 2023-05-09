using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Clobbopus : Pokemon
{
	public override string Name => "Clobbopus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Limber() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
	public override Stats BaseStats => new Stats(50, 68, 60, 50, 50, 32);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Rocksmash(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Feint() },
		[10] = new List<Move>() { new Moves.Bind() },
		[15] = new List<Move>() { new Moves.Detect() },
		[20] = new List<Move>() { new Moves.Brickbreak() },
		[25] = new List<Move>() { new Moves.Bulkup() },
		[30] = new List<Move>() { new Moves.Submission() },
		[35] = new List<Move>() { new Moves.Taunt() },
		[40] = new List<Move>() { new Moves.Reversal() },
		[45] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dive(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Liquidation(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Waterfall(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Circlethrow(), new Moves.Painsplit(), new Moves.Poweruppunch(), new Moves.Seismictoss(), new Moves.Soak(), new Moves.Suckerpunch() };
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