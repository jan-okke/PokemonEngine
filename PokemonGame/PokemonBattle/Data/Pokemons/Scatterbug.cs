using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Scatterbug : Pokemon
{
	public override string Name => "Scatterbug";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust(), new Abilities.Compoundeyes() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
	public override Stats BaseStats => new Stats(38, 35, 40, 27, 25, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Stringshot() },
		[6] = new List<Move>() { new Moves.Stunspore() },
		[15] = new List<Move>() { new Moves.Bugbite() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Poisonpowder(), new Moves.Ragepowder(), new Moves.Stunspore() };
	public override int Weight => 25;
	public override int ExpYield => 40;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}