using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Gumshoos : Pokemon
{
	public override string Name => "Gumshoos";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stakeout(), new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(88, 110, 60, 55, 60, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer(), new Moves.Pursuit(), new Moves.Sandattack() },
		[3] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Pursuit() },
		[10] = new List<Move>() { new Moves.Sandattack() },
		[13] = new List<Move>() { new Moves.Odorsleuth() },
		[16] = new List<Move>() { new Moves.Bide() },
		[19] = new List<Move>() { new Moves.Bite() },
		[23] = new List<Move>() { new Moves.Mudslap() },
		[27] = new List<Move>() { new Moves.Superfang() },
		[31] = new List<Move>() { new Moves.Takedown() },
		[35] = new List<Move>() { new Moves.Scaryface() },
		[39] = new List<Move>() { new Moves.Crunch() },
		[43] = new List<Move>() { new Moves.Hyperfang() },
		[47] = new List<Move>() { new Moves.Yawn() },
		[51] = new List<Move>() { new Moves.Thrash() },
		[55] = new List<Move>() { new Moves.Rest() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 142;
	public override int ExpYield => 146;
	public override int CatchRate => 127;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}