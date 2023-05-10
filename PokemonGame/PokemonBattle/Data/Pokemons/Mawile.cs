using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mawile : Pokemon
{
	public override string Name => "Mawile";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(50, 85, 85, 55, 55, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Fairywind() },
		[8] = new List<Move>() { new Moves.Batonpass() },
		[12] = new List<Move>() { new Moves.Bite() },
		[16] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[20] = new List<Move>() { new Moves.Suckerpunch() },
		[24] = new List<Move>() { new Moves.Irondefense() },
		[28] = new List<Move>() { new Moves.Crunch() },
		[32] = new List<Move>() { new Moves.Sweetscent() },
		[36] = new List<Move>() { new Moves.Ironhead() },
		[40] = new List<Move>() { new Moves.Taunt() },
		[44] = new List<Move>() { new Moves.Faketears() },
		[48] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyterrain(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderfang(), new Moves.Thunderpunch(), new Moves.Torment() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Firefang(), new Moves.Guardswap(), new Moves.Icefang(), new Moves.Metalburst(), new Moves.Mistyterrain(), new Moves.Poisonfang(), new Moves.Poweruppunch(), new Moves.Seismictoss(), new Moves.Slam(), new Moves.Suckerpunch(), new Moves.Thunderfang(), new Moves.Tickle() };
	public override int Weight => 115;
	public override int ExpYield => 133;
	public override int CatchRate => 45;
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