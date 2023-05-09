using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cranidos : Pokemon
{
	public override string Name => "Cranidos";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Moldbreaker() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(67, 125, 40, 30, 30, 58);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Headbutt(), new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Focusenergy() },
		[10] = new List<Move>() { new Moves.Rockpolish() },
		[15] = new List<Move>() { new Moves.Takedown() },
		[19] = new List<Move>() { new Moves.Scaryface() },
		[24] = new List<Move>() { new Moves.Assurance() },
		[28] = new List<Move>() { new Moves.Swordsdance() },
		[33] = new List<Move>() { new Moves.Ancientpower() },
		[37] = new List<Move>() { new Moves.Zenheadbutt() },
		[42] = new List<Move>() { new Moves.Screech() },
		[46] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Spite(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Crunch(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Hammerarm(), new Moves.Ironhead(), new Moves.Leer(), new Moves.Slam(), new Moves.Stomp(), new Moves.Thrash(), new Moves.Whirlwind() };
	public override int Weight => 315;
	public override int ExpYield => 70;
	public override int CatchRate => 45;
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