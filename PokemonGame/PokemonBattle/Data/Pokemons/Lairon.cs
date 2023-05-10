using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lairon : Pokemon
{
	public override string Name => "Lairon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
	public override Stats BaseStats => new Stats(60, 90, 140, 50, 50, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden(), new Moves.Metalclaw(), new Moves.Rocktomb() },
		[12] = new List<Move>() { new Moves.Roar() },
		[16] = new List<Move>() { new Moves.Headbutt() },
		[20] = new List<Move>() { new Moves.Protect() },
		[24] = new List<Move>() { new Moves.Rockslide() },
		[28] = new List<Move>() { new Moves.Ironhead() },
		[35] = new List<Move>() { new Moves.Metalsound() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[46] = new List<Move>() { new Moves.Autotomize() },
		[52] = new List<Move>() { new Moves.Irontail() },
		[58] = new List<Move>() { new Moves.Irondefense() },
		[64] = new List<Move>() { new Moves.Heavyslam() },
		[70] = new List<Move>() { new Moves.Doubleedge() },
		[76] = new List<Move>() { new Moves.Metalburst() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Uproar(), new Moves.Waterpulse() };
	public override int Weight => 1200;
	public override int ExpYield => 151;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}