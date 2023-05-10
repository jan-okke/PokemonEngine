using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Typhlosion : Pokemon
{
	public override string Name => "Typhlosion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flashfire() };
	public override Stats BaseStats => new Stats(78, 84, 78, 109, 85, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Eruption(), new Moves.Doubleedge(), new Moves.Gyroball(), new Moves.Tackle(), new Moves.Leer(), new Moves.Smokescreen(), new Moves.Ember() },
		[6] = new List<Move>() { new Moves.Smokescreen() },
		[10] = new List<Move>() { new Moves.Ember() },
		[13] = new List<Move>() { new Moves.Quickattack() },
		[20] = new List<Move>() { new Moves.Flamewheel() },
		[24] = new List<Move>() { new Moves.Defensecurl() },
		[31] = new List<Move>() { new Moves.Swift() },
		[35] = new List<Move>() { new Moves.Flamecharge() },
		[43] = new List<Move>() { new Moves.Lavaplume() },
		[48] = new List<Move>() { new Moves.Flamethrower() },
		[56] = new List<Move>() { new Moves.Inferno() },
		[61] = new List<Move>() { new Moves.Rollout() },
		[69] = new List<Move>() { new Moves.Doubleedge() },
		[74] = new List<Move>() { new Moves.Burnup() },
		[82] = new List<Move>() { new Moves.Eruption() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Blastburn(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Laserfocus(), new Moves.Lowkick(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Wildcharge(), new Moves.Willowisp(), new Moves.Workup() };
	public override int Weight => 795;
	public override int ExpYield => 267;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}