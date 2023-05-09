using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Phanpy : Pokemon
{
	public override string Name => "Phanpy";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(90, 60, 60, 40, 40, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl(), new Moves.Defensecurl() },
		[6] = new List<Move>() { new Moves.Flail() },
		[10] = new List<Move>() { new Moves.Rollout() },
		[15] = new List<Move>() { new Moves.Bulldoze() },
		[19] = new List<Move>() { new Moves.Endure() },
		[24] = new List<Move>() { new Moves.Slam() },
		[28] = new List<Move>() { new Moves.Takedown() },
		[33] = new List<Move>() { new Moves.Charm() },
		[37] = new List<Move>() { new Moves.Lastresort() },
		[42] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Bodyslam(), new Moves.Counter(), new Moves.Endeavor(), new Moves.Fissure(), new Moves.Focusenergy(), new Moves.Headsmash(), new Moves.Heavyslam(), new Moves.Highhorsepower(), new Moves.Iceshard(), new Moves.Mudslap(), new Moves.Playrough(), new Moves.Snore() };
	public override int Weight => 335;
	public override int ExpYield => 66;
	public override int CatchRate => 120;
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