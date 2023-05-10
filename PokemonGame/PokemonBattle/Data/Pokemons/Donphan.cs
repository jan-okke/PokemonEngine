using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Donphan : Pokemon
{
	public override string Name => "Donphan";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(90, 120, 120, 60, 60, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Furyattack() },
		[1] = new List<Move>() { new Moves.Furyattack(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Hornattack(), new Moves.Bulldoze(), new Moves.Growl(), new Moves.Defensecurl() },
		[6] = new List<Move>() { new Moves.Rapidspin() },
		[10] = new List<Move>() { new Moves.Rollout() },
		[15] = new List<Move>() { new Moves.Assurance() },
		[19] = new List<Move>() { new Moves.Knockoff() },
		[24] = new List<Move>() { new Moves.Slam() },
		[30] = new List<Move>() { new Moves.Rocktomb() },
		[37] = new List<Move>() { new Moves.Scaryface() },
		[43] = new List<Move>() { new Moves.Earthquake() },
		[50] = new List<Move>() { new Moves.Gigaimpact() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Bounce(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger() };
	public override int Weight => 1200;
	public override int ExpYield => 175;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}