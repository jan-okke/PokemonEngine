using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Kricketot : Pokemon
{
	public override string Name => "Kricketot";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
	public override Stats BaseStats => new Stats(37, 25, 41, 25, 41, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Pound() },
		[6] = new List<Move>() { new Moves.Strugglebug() },
		[16] = new List<Move>() { new Moves.Bugbite() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Endeavor(), new Moves.Strugglebug(), new Moves.Uproar() };
	public override int Weight => 22;
	public override int ExpYield => 39;
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