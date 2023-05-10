using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aurorus : Pokemon
{
	public override string Name => "Aurorus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Refrigerate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Snowwarning() };
	public override Stats BaseStats => new Stats(123, 77, 72, 99, 92, 58);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Powdersnow(), new Moves.Growl(), new Moves.Encore(), new Moves.Ancientpower() },
		[12] = new List<Move>() { new Moves.Icywind() },
		[16] = new List<Move>() { new Moves.Round() },
		[20] = new List<Move>() { new Moves.Mist() },
		[24] = new List<Move>() { new Moves.Aurorabeam() },
		[28] = new List<Move>() { new Moves.Thunderwave() },
		[32] = new List<Move>() { new Moves.Naturepower() },
		[36] = new List<Move>() { new Moves.Freezedry() },
		[42] = new List<Move>() { new Moves.Icebeam() },
		[48] = new List<Move>() { new Moves.Lightscreen() },
		[54] = new List<Move>() { new Moves.Hail() },
		[60] = new List<Move>() { new Moves.Blizzard() },
		[66] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Mudshot(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Weatherball(), new Moves.Zenheadbutt() };
	public override int Weight => 2250;
	public override int ExpYield => 104;
	public override int CatchRate => 45;
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