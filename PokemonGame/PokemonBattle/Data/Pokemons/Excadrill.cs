using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Excadrill : Pokemon
{
	public override string Name => "Excadrill";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandrush(), new Abilities.Sandforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moldbreaker() };
	public override Stats BaseStats => new Stats(110, 135, 60, 50, 65, 88);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Horndrill() },
		[1] = new List<Move>() { new Moves.Horndrill(), new Moves.Mudslap(), new Moves.Rapidspin(), new Moves.Scratch(), new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Furyswipes() },
		[16] = new List<Move>() { new Moves.Metalclaw() },
		[20] = new List<Move>() { new Moves.Sandstorm() },
		[24] = new List<Move>() { new Moves.Crushclaw() },
		[28] = new List<Move>() { new Moves.Rockslide() },
		[34] = new List<Move>() { new Moves.Dig() },
		[40] = new List<Move>() { new Moves.Swordsdance() },
		[46] = new List<Move>() { new Moves.Drillrun() },
		[52] = new List<Move>() { new Moves.Earthquake() },
		[58] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
	public override int Weight => 404;
	public override int ExpYield => 178;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}