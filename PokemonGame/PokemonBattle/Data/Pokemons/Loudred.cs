using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Loudred : Pokemon
{
	public override string Name => "Loudred";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Soundproof() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
	public override Stats BaseStats => new Stats(84, 71, 43, 71, 43, 48);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Bite() },
		[1] = new List<Move>() { new Moves.Bite(), new Moves.Astonish(), new Moves.Pound(), new Moves.Echoedvoice(), new Moves.Howl() },
		[15] = new List<Move>() { new Moves.Rest(), new Moves.Sleeptalk() },
		[23] = new List<Move>() { new Moves.Stomp() },
		[29] = new List<Move>() { new Moves.Roar() },
		[36] = new List<Move>() { new Moves.Supersonic() },
		[43] = new List<Move>() { new Moves.Uproar() },
		[50] = new List<Move>() { new Moves.Screech() },
		[57] = new List<Move>() { new Moves.Hypervoice() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Overheat(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 405;
	public override int ExpYield => 126;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}