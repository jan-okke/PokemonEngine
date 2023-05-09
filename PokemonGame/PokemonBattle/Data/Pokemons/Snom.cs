using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Snom : Pokemon
{
	public override string Name => "Snom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icescales() };
	public override Stats BaseStats => new Stats(30, 25, 35, 45, 30, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Strugglebug() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Fairywind(), new Moves.Mirrorcoat() };
	public override int Weight => 38;
	public override int ExpYield => 37;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}