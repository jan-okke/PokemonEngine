using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Amaura : Pokemon
{
	public override string Name => "Amaura";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Refrigerate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Snowwarning() };
	public override Stats BaseStats => new Stats(77, 59, 50, 67, 63, 46);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Encore() },
		[8] = new List<Move>() { new Moves.Ancientpower() },
		[12] = new List<Move>() { new Moves.Icywind() },
		[16] = new List<Move>() { new Moves.Round() },
		[20] = new List<Move>() { new Moves.Mist() },
		[24] = new List<Move>() { new Moves.Aurorabeam() },
		[28] = new List<Move>() { new Moves.Thunderwave() },
		[32] = new List<Move>() { new Moves.Naturepower() },
		[36] = new List<Move>() { new Moves.Freezedry() },
		[40] = new List<Move>() { new Moves.Icebeam() },
		[44] = new List<Move>() { new Moves.Lightscreen() },
		[48] = new List<Move>() { new Moves.Hail() },
		[52] = new List<Move>() { new Moves.Blizzard() },
		[56] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Earthpower(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Weatherball(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Auroraveil(), new Moves.Discharge(), new Moves.Haze(), new Moves.Mirrorcoat(), new Moves.Rockthrow(), new Moves.Takedown() };
	public override int Weight => 252;
	public override int ExpYield => 72;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}