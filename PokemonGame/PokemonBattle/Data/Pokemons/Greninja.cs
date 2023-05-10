using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Greninja : Pokemon
{
	public override string Name => "Greninja";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Protean() };
	public override Stats BaseStats => new Stats(72, 95, 67, 103, 71, 122);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Watershuriken() },
		[1] = new List<Move>() { new Moves.Watershuriken(), new Moves.Nightslash(), new Moves.Haze(), new Moves.Roleplay(), new Moves.Matblock(), new Moves.Pound(), new Moves.Growl(), new Moves.Bubble(), new Moves.Quickattack() },
		[5] = new List<Move>() { new Moves.Bubble() },
		[8] = new List<Move>() { new Moves.Quickattack() },
		[10] = new List<Move>() { new Moves.Lick() },
		[14] = new List<Move>() { new Moves.Waterpulse() },
		[19] = new List<Move>() { new Moves.Smokescreen() },
		[23] = new List<Move>() { new Moves.Shadowsneak() },
		[28] = new List<Move>() { new Moves.Spikes() },
		[33] = new List<Move>() { new Moves.Feintattack() },
		[42] = new List<Move>() { new Moves.Substitute() },
		[49] = new List<Move>() { new Moves.Extrasensory() },
		[56] = new List<Move>() { new Moves.Doubleteam() },
		[68] = new List<Move>() { new Moves.Hydropump() },
		[70] = new List<Move>() { new Moves.Haze() },
		[77] = new List<Move>() { new Moves.Nightslash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brutalswing(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hydrocannon(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lowkick(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 400;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}