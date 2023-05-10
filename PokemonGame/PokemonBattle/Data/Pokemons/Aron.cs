using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aron : Pokemon
{
	public override string Name => "Aron";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
	public override Stats BaseStats => new Stats(50, 70, 100, 40, 40, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
		[4] = new List<Move>() { new Moves.Metalclaw() },
		[8] = new List<Move>() { new Moves.Rocktomb() },
		[12] = new List<Move>() { new Moves.Roar() },
		[16] = new List<Move>() { new Moves.Headbutt() },
		[20] = new List<Move>() { new Moves.Protect() },
		[24] = new List<Move>() { new Moves.Rockslide() },
		[28] = new List<Move>() { new Moves.Ironhead() },
		[33] = new List<Move>() { new Moves.Metalsound() },
		[36] = new List<Move>() { new Moves.Takedown() },
		[40] = new List<Move>() { new Moves.Autotomize() },
		[44] = new List<Move>() { new Moves.Irontail() },
		[48] = new List<Move>() { new Moves.Irondefense() },
		[52] = new List<Move>() { new Moves.Heavyslam() },
		[56] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Metalburst() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Curse(), new Moves.Dragonrush(), new Moves.Endeavor(), new Moves.Headsmash(), new Moves.Ironhead(), new Moves.Mudslap(), new Moves.Reversal(), new Moves.Screech(), new Moves.Stomp(), new Moves.Superpower() };
	public override int Weight => 600;
	public override int ExpYield => 66;
	public override int CatchRate => 180;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}