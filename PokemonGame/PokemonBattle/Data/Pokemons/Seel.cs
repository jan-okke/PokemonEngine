using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Seel : Pokemon
{
	public override string Name => "Seel";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Hydration() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Icebody() };
	public override Stats BaseStats => new Stats(65, 45, 55, 45, 70, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Headbutt() },
		[3] = new List<Move>() { new Moves.Growl() },
		[7] = new List<Move>() { new Moves.Watergun() },
		[11] = new List<Move>() { new Moves.Icywind() },
		[13] = new List<Move>() { new Moves.Encore() },
		[17] = new List<Move>() { new Moves.Iceshard() },
		[21] = new List<Move>() { new Moves.Rest() },
		[23] = new List<Move>() { new Moves.Aquaring() },
		[27] = new List<Move>() { new Moves.Aurorabeam() },
		[31] = new List<Move>() { new Moves.Aquajet() },
		[33] = new List<Move>() { new Moves.Brine() },
		[37] = new List<Move>() { new Moves.Takedown() },
		[41] = new List<Move>() { new Moves.Dive() },
		[43] = new List<Move>() { new Moves.Aquatail() },
		[47] = new List<Move>() { new Moves.Icebeam() },
		[51] = new List<Move>() { new Moves.Safeguard() },
		[53] = new List<Move>() { new Moves.Hail() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Disable(), new Moves.Encore(), new Moves.Entrainment(), new Moves.Fakeout(), new Moves.Horndrill(), new Moves.Iciclespear(), new Moves.Lick(), new Moves.Perishsong(), new Moves.Slam(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
	public override int Weight => 900;
	public override int ExpYield => 65;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}