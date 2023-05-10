using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Sudowoodo : Pokemon
{
	public override string Name => "Sudowoodo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(70, 100, 115, 30, 65, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slam() },
		[1] = new List<Move>() { new Moves.Slam(), new Moves.Stoneedge(), new Moves.Hammerarm(), new Moves.Woodhammer(), new Moves.Faketears(), new Moves.Copycat(), new Moves.Flail(), new Moves.Rockthrow() },
		[12] = new List<Move>() { new Moves.Block() },
		[16] = new List<Move>() { new Moves.Mimic() },
		[20] = new List<Move>() { new Moves.Rocktomb() },
		[24] = new List<Move>() { new Moves.Tearfullook() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Rockslide() },
		[36] = new List<Move>() { new Moves.Lowkick() },
		[40] = new List<Move>() { new Moves.Counter() },
		[44] = new List<Move>() { new Moves.Doubleedge() },
		[48] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Defensecurl(), new Moves.Harden(), new Moves.Headbutt(), new Moves.Rollout(), new Moves.Sandtomb(), new Moves.Selfdestruct() };
	public override int Weight => 380;
	public override int ExpYield => 144;
	public override int CatchRate => 65;
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