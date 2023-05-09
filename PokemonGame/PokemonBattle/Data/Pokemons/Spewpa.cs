using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Spewpa : Pokemon
{
	public override string Name => "Spewpa";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
	public override Stats BaseStats => new Stats(45, 22, 60, 27, 30, 29);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Protect() },
		[1] = new List<Move>() { new Moves.Protect(), new Moves.Harden() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Electroweb(), new Moves.Irondefense(), new Moves.Protect() };
	public override int Weight => 84;
	public override int ExpYield => 75;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}