using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dewgong : Pokemon
{
	public override string Name => "Dewgong";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icebody() };
	public override Stats BaseStats => new Stats(90, 70, 80, 70, 95, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Sheercold() },
		[1] = new List<Move>() { new Moves.Sheercold(), new Moves.Headbutt(), new Moves.Growl(), new Moves.Bubblebeam(), new Moves.Icywind() },
		[3] = new List<Move>() { new Moves.Growl() },
		[7] = new List<Move>() { new Moves.Bubblebeam() },
		[11] = new List<Move>() { new Moves.Icywind() },
		[13] = new List<Move>() { new Moves.Encore() },
		[17] = new List<Move>() { new Moves.Iceshard() },
		[21] = new List<Move>() { new Moves.Rest() },
		[23] = new List<Move>() { new Moves.Aquaring() },
		[27] = new List<Move>() { new Moves.Aurorabeam() },
		[31] = new List<Move>() { new Moves.Aquajet() },
		[33] = new List<Move>() { new Moves.Brine() },
		[39] = new List<Move>() { new Moves.Takedown() },
		[45] = new List<Move>() { new Moves.Dive() },
		[49] = new List<Move>() { new Moves.Aquatail() },
		[55] = new List<Move>() { new Moves.Icebeam() },
		[61] = new List<Move>() { new Moves.Safeguard() },
		[65] = new List<Move>() { new Moves.Hail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Frostbreath(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override int Weight => 1200;
	public override int ExpYield => 166;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}