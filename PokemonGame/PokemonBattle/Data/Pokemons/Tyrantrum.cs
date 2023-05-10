using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tyrantrum : Pokemon
{
	public override string Name => "Tyrantrum";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Strongjaw() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rockhead() };
	public override Stats BaseStats => new Stats(82, 121, 119, 69, 59, 71);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Roar(), new Moves.Ancientpower() },
		[12] = new List<Move>() { new Moves.Charm() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Dragontail() },
		[24] = new List<Move>() { new Moves.Stomp() },
		[28] = new List<Move>() { new Moves.Rockslide() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Dragonclaw() },
		[42] = new List<Move>() { new Moves.Thrash() },
		[48] = new List<Move>() { new Moves.Earthquake() },
		[54] = new List<Move>() { new Moves.Horndrill() },
		[60] = new List<Move>() { new Moves.Gigaimpact() },
		[66] = new List<Move>() { new Moves.Headsmash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Thunderfang(), new Moves.Zenheadbutt() };
	public override int Weight => 2700;
	public override int ExpYield => 182;
	public override int CatchRate => 45;
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