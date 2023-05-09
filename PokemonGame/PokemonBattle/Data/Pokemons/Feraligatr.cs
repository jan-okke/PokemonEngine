using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Feraligatr : Pokemon
{
	public override string Name => "Feraligatr";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(85, 105, 100, 79, 83, 78);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Agility(), new Moves.Scratch(), new Moves.Leer(), new Moves.Watergun(), new Moves.Mudslap() },
		[6] = new List<Move>() { new Moves.Watergun() },
		[8] = new List<Move>() { new Moves.Mudslap() },
		[13] = new List<Move>() { new Moves.Bite() },
		[15] = new List<Move>() { new Moves.Scaryface() },
		[21] = new List<Move>() { new Moves.Icefang() },
		[24] = new List<Move>() { new Moves.Flail() },
		[32] = new List<Move>() { new Moves.Crunch() },
		[37] = new List<Move>() { new Moves.Lowkick() },
		[45] = new List<Move>() { new Moves.Slash() },
		[50] = new List<Move>() { new Moves.Screech() },
		[58] = new List<Move>() { new Moves.Thrash() },
		[63] = new List<Move>() { new Moves.Aquatail() },
		[71] = new List<Move>() { new Moves.Superpower() },
		[76] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dragontail(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydrocannon(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Outrage(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup() };
	public override int Weight => 888;
	public override int ExpYield => 265;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}