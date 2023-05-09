using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Articuno : Pokemon
{
	public override string Name => "Articuno";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Snowcloak() };
	public override Stats BaseStats => new Stats(90, 85, 100, 95, 125, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Mist() },
		[5] = new List<Move>() { new Moves.Powdersnow() },
		[10] = new List<Move>() { new Moves.Reflect() },
		[15] = new List<Move>() { new Moves.Iceshard() },
		[20] = new List<Move>() { new Moves.Agility() },
		[25] = new List<Move>() { new Moves.Ancientpower() },
		[30] = new List<Move>() { new Moves.Tailwind() },
		[35] = new List<Move>() { new Moves.Freezedry() },
		[40] = new List<Move>() { new Moves.Roost() },
		[45] = new List<Move>() { new Moves.Icebeam() },
		[50] = new List<Move>() { new Moves.Hail() },
		[55] = new List<Move>() { new Moves.Hurricane() },
		[60] = new List<Move>() { new Moves.Mindreader() },
		[65] = new List<Move>() { new Moves.Blizzard() },
		[70] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bravebird(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tripleaxel(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Weatherball() };
	public override int Weight => 554;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}