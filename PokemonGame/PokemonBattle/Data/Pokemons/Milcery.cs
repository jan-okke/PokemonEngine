using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Milcery : Pokemon
{
	public override string Name => "Milcery";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sweetveil() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Aromaveil() };
	public override Stats BaseStats => new Stats(45, 40, 40, 50, 61, 34);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Aromaticmist() },
		[5] = new List<Move>() { new Moves.Sweetkiss() },
		[10] = new List<Move>() { new Moves.Sweetscent() },
		[15] = new List<Move>() { new Moves.Drainingkiss() },
		[20] = new List<Move>() { new Moves.Aromatherapy() },
		[25] = new List<Move>() { new Moves.Attract() },
		[30] = new List<Move>() { new Moves.Acidarmor() },
		[35] = new List<Move>() { new Moves.Dazzlinggleam() },
		[40] = new List<Move>() { new Moves.Recover() },
		[45] = new List<Move>() { new Moves.Mistyterrain() },
		[50] = new List<Move>() { new Moves.Entrainment() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Mistyterrain(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Babydolleyes(), new Moves.Lastresort() };
	public override int Weight => 3;
	public override int ExpYield => 54;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}