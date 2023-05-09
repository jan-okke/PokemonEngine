using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pyukumuku : Pokemon
{
	public override string Name => "Pyukumuku";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innardsout() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unaware() };
	public override Stats BaseStats => new Stats(55, 60, 130, 30, 130, 5);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Batonpass(), new Moves.Harden() },
		[5] = new List<Move>() { new Moves.Helpinghand() },
		[10] = new List<Move>() { new Moves.Taunt() },
		[15] = new List<Move>() { new Moves.Safeguard() },
		[20] = new List<Move>() { new Moves.Counter() },
		[25] = new List<Move>() { new Moves.Purify() },
		[30] = new List<Move>() { new Moves.Curse() },
		[35] = new List<Move>() { new Moves.Gastroacid() },
		[40] = new List<Move>() { new Moves.Painsplit() },
		[45] = new List<Move>() { new Moves.Recover() },
		[50] = new List<Move>() { new Moves.Soak() },
		[55] = new List<Move>() { new Moves.Toxic() },
		[60] = new List<Move>() { new Moves.Memento() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Endure(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Substitute(), new Moves.Taunt(), new Moves.Venomdrench() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Mirrorcoat(), new Moves.Spite(), new Moves.Swagger(), new Moves.Tickle() };
	public override int Weight => 12;
	public override int ExpYield => 144;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}