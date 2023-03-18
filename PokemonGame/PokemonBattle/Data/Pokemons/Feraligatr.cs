using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Feraligatr : Pokemon
	{
		public override string Name => "Feraligatr";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(85, 105, 100, 78, 79, 83);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Agility(), new Scratch(), new Leer(), new Watergun(), new Mudslap() },
			[6] = new List<Move>() { new Watergun() },
			[8] = new List<Move>() { new Mudslap() },
			[13] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Scaryface() },
			[21] = new List<Move>() { new Icefang() },
			[24] = new List<Move>() { new Flail() },
			[32] = new List<Move>() { new Crunch() },
			[37] = new List<Move>() { new Lowkick() },
			[45] = new List<Move>() { new Slash() },
			[50] = new List<Move>() { new Screech() },
			[58] = new List<Move>() { new Thrash() },
			[63] = new List<Move>() { new Aquatail() },
			[71] = new List<Move>() { new Superpower() },
			[76] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Avalanche(), new Blizzard(), new Block(), new Brickbreak(), new Bulldoze(), new Confide(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Dragonclaw(), new Dragonpulse(), new Dragontail(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydrocannon(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Liquidation(), new Lowkick(), new Outrage(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Spite(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
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
}