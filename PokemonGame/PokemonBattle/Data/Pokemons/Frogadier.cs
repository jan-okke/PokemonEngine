using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Frogadier : Pokemon
{
	public override string Name => "Frogadier";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Protean() };
	public override Stats BaseStats => new Stats(54, 63, 52, 83, 56, 97);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Pound(), new Moves.Growl(), new Moves.Bubble() },
		[5] = new List<Move>() { new Moves.Bubble() },
		[8] = new List<Move>() { new Moves.Quickattack() },
		[10] = new List<Move>() { new Moves.Lick() },
		[14] = new List<Move>() { new Moves.Waterpulse() },
		[19] = new List<Move>() { new Moves.Smokescreen() },
		[23] = new List<Move>() { new Moves.Round() },
		[28] = new List<Move>() { new Moves.Fling() },
		[33] = new List<Move>() { new Moves.Smackdown() },
		[40] = new List<Move>() { new Moves.Substitute() },
		[45] = new List<Move>() { new Moves.Bounce() },
		[50] = new List<Move>() { new Moves.Doubleteam() },
		[56] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 109;
	public override int ExpYield => 142;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}