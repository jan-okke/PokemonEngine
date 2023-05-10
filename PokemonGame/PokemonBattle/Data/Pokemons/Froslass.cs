using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Froslass : Pokemon
{
	public override string Name => "Froslass";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Snowcloak() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cursedbody() };
	public override Stats BaseStats => new Stats(70, 80, 70, 80, 70, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Hex() },
		[1] = new List<Move>() { new Moves.Hex(), new Moves.Destinybond(), new Moves.Protect(), new Moves.Bite(), new Moves.Icefang(), new Moves.Headbutt(), new Moves.Crunch(), new Moves.Powdersnow(), new Moves.Astonish(), new Moves.Leer(), new Moves.Doubleteam() },
		[15] = new List<Move>() { new Moves.Iceshard() },
		[20] = new List<Move>() { new Moves.Drainingkiss() },
		[25] = new List<Move>() { new Moves.Icywind() },
		[30] = new List<Move>() { new Moves.Frostbreath() },
		[35] = new List<Move>() { new Moves.Confuseray() },
		[40] = new List<Move>() { new Moves.Hail() },
		[47] = new List<Move>() { new Moves.Willowisp() },
		[54] = new List<Move>() { new Moves.Auroraveil() },
		[61] = new List<Move>() { new Moves.Shadowball() },
		[68] = new List<Move>() { new Moves.Blizzard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Tripleaxel(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override int Weight => 266;
	public override int ExpYield => 168;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}