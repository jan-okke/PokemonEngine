using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Yungoos : Pokemon
{
	public override string Name => "Yungoos";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stakeout(), new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Adaptability() };
	public override Stats BaseStats => new Stats(48, 70, 30, 30, 30, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Leer() },
		[7] = new List<Move>() { new Moves.Pursuit() },
		[10] = new List<Move>() { new Moves.Sandattack() },
		[13] = new List<Move>() { new Moves.Odorsleuth() },
		[16] = new List<Move>() { new Moves.Bide() },
		[19] = new List<Move>() { new Moves.Bite() },
		[22] = new List<Move>() { new Moves.Mudslap() },
		[25] = new List<Move>() { new Moves.Superfang() },
		[28] = new List<Move>() { new Moves.Takedown() },
		[31] = new List<Move>() { new Moves.Scaryface() },
		[34] = new List<Move>() { new Moves.Crunch() },
		[37] = new List<Move>() { new Moves.Hyperfang() },
		[40] = new List<Move>() { new Moves.Yawn() },
		[43] = new List<Move>() { new Moves.Thrash() },
		[46] = new List<Move>() { new Moves.Rest() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Firefang(), new Moves.Icefang(), new Moves.Lastresort(), new Moves.Revenge(), new Moves.Thunderfang() };
	public override int Weight => 60;
	public override int ExpYield => 51;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}