using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cosmoem : Pokemon
{
	public override string Name => "Cosmoem";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(43, 29, 131, 29, 131, 37);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Cosmicpower() },
		[1] = new List<Move>() { new Moves.Cosmicpower(), new Moves.Teleport() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Cosmicpower() };
	public override int Weight => 9999;
	public override int ExpYield => 140;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}