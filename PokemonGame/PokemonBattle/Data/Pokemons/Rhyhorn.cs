using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rhyhorn : Pokemon
{
	public override string Name => "Rhyhorn";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Lightningrod(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Reckless() };
	public override Stats BaseStats => new Stats(80, 85, 95, 30, 30, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Smackdown() },
		[10] = new List<Move>() { new Moves.Bulldoze() },
		[15] = new List<Move>() { new Moves.Hornattack() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[25] = new List<Move>() { new Moves.Stomp() },
		[30] = new List<Move>() { new Moves.Rockblast() },
		[35] = new List<Move>() { new Moves.Drillrun() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[45] = new List<Move>() { new Moves.Earthquake() },
		[50] = new List<Move>() { new Moves.Stoneedge() },
		[55] = new List<Move>() { new Moves.Megahorn() },
		[60] = new List<Move>() { new Moves.Horndrill() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Megahorn(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Crunch(), new Moves.Crushclaw(), new Moves.Curse(), new Moves.Dragonrush(), new Moves.Firefang(), new Moves.Guardsplit(), new Moves.Icefang(), new Moves.Metalburst(), new Moves.Reversal(), new Moves.Skullbash(), new Moves.Thunderfang() };
	public override int Weight => 1150;
	public override int ExpYield => 69;
	public override int CatchRate => 120;
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