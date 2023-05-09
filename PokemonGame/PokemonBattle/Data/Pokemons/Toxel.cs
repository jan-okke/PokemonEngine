using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Toxel : Pokemon
{
	public override string Name => "Toxel";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rattled(), new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Klutz() };
	public override Stats BaseStats => new Stats(40, 38, 35, 54, 35, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Belch(), new Moves.Tearfullook(), new Moves.Nuzzle(), new Moves.Growl(), new Moves.Flail(), new Moves.Acid() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Endeavor(), new Moves.Metalsound(), new Moves.Poweruppunch() };
	public override int Weight => 110;
	public override int ExpYield => 48;
	public override int CatchRate => 75;
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