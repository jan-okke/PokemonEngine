using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Golem : Pokemon
{
	public override string Name => "Golem";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead(), new Abilities.Sturdy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(80, 120, 130, 55, 65, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Heavyslam(), new Moves.Tackle(), new Moves.Defensecurl(), new Moves.Rockpolish() },
		[4] = new List<Move>() { new Moves.Sandstorm() },
		[6] = new List<Move>() { new Moves.Rockpolish() },
		[10] = new List<Move>() { new Moves.Rollout() },
		[12] = new List<Move>() { new Moves.Harden() },
		[16] = new List<Move>() { new Moves.Rockthrow() },
		[18] = new List<Move>() { new Moves.Smackdown() },
		[22] = new List<Move>() { new Moves.Bulldoze() },
		[24] = new List<Move>() { new Moves.Selfdestruct() },
		[30] = new List<Move>() { new Moves.Stealthrock() },
		[34] = new List<Move>() { new Moves.Rockblast() },
		[40] = new List<Move>() { new Moves.Earthquake() },
		[44] = new List<Move>() { new Moves.Explosion() },
		[50] = new List<Move>() { new Moves.Doubleedge() },
		[54] = new List<Move>() { new Moves.Stoneedge() },
		[60] = new List<Move>() { new Moves.Heavyslam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Naturepower(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thunderpunch() };
	public override int Weight => 3000;
	public override int ExpYield => 248;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 3,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}