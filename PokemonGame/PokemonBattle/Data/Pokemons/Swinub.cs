using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Swinub : Pokemon
{
	public override string Name => "Swinub";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Snowcloak() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Thickfat() };
	public override Stats BaseStats => new Stats(50, 50, 40, 30, 30, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Mudslap() },
		[5] = new List<Move>() { new Moves.Powdersnow() },
		[10] = new List<Move>() { new Moves.Flail() },
		[15] = new List<Move>() { new Moves.Iceshard() },
		[20] = new List<Move>() { new Moves.Mist() },
		[25] = new List<Move>() { new Moves.Endure() },
		[30] = new List<Move>() { new Moves.Icywind() },
		[35] = new List<Move>() { new Moves.Amnesia() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[45] = new List<Move>() { new Moves.Earthquake() },
		[50] = new List<Move>() { new Moves.Blizzard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swagger() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Bite(), new Moves.Bodyslam(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Freezedry(), new Moves.Iciclecrash(), new Moves.Iciclespear(), new Moves.Mudshot(), new Moves.Mudshot(), new Moves.Takedown() };
	public override int Weight => 65;
	public override int ExpYield => 50;
	public override int CatchRate => 225;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}