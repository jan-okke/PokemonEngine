using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Beldum : Pokemon
{
	public override string Name => "Beldum";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightmetal() };
	public override Stats BaseStats => new Stats(40, 55, 80, 35, 60, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Steelbeam(), new Moves.Zenheadbutt() };
	public override int Weight => 952;
	public override int ExpYield => 60;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}