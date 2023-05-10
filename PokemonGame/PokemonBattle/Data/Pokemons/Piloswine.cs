using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Piloswine : Pokemon
{
	public override string Name => "Piloswine";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Snowcloak() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Thickfat() };
	public override Stats BaseStats => new Stats(100, 100, 80, 60, 60, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Icefang() },
		[1] = new List<Move>() { new Moves.Icefang(), new Moves.Ancientpower(), new Moves.Tackle(), new Moves.Mudslap(), new Moves.Powdersnow(), new Moves.Flail() },
		[15] = new List<Move>() { new Moves.Iceshard() },
		[20] = new List<Move>() { new Moves.Mist() },
		[25] = new List<Move>() { new Moves.Endure() },
		[30] = new List<Move>() { new Moves.Icywind() },
		[37] = new List<Move>() { new Moves.Amnesia() },
		[44] = new List<Move>() { new Moves.Takedown() },
		[51] = new List<Move>() { new Moves.Earthquake() },
		[58] = new List<Move>() { new Moves.Blizzard() },
		[65] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swagger() };
	public override int Weight => 558;
	public override int ExpYield => 158;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}