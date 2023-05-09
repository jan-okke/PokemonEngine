using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Yamper : Pokemon
{
	public override string Name => "Yamper";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ballfetch() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(59, 45, 50, 40, 50, 26);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Nuzzle() },
		[10] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Roar() },
		[20] = new List<Move>() { new Moves.Spark() },
		[26] = new List<Move>() { new Moves.Charm() },
		[30] = new List<Move>() { new Moves.Crunch() },
		[35] = new List<Move>() { new Moves.Charge() },
		[40] = new List<Move>() { new Moves.Wildcharge() },
		[45] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Charm(), new Moves.Crunch(), new Moves.Dig(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Discharge(), new Moves.Doubleedge(), new Moves.Flamecharge(), new Moves.Howl(), new Moves.Sandattack() };
	public override int Weight => 135;
	public override int ExpYield => 54;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}