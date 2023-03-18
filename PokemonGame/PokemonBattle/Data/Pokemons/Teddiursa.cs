using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Teddiursa : Pokemon
	{
		public override string Name => "Teddiursa";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Honeygather() };
		public override Stats BaseStats => new Stats(60, 80, 50, 50, 50, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fling(), new Covet(), new Scratch(), new Babydolleyes(), new Lick(), new Faketears() },
			[8] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Payback() },
			[22] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Playnice() },
			[29] = new List<Move>() { new Slash() },
			[36] = new List<Move>() { new Charm() },
			[43] = new List<Move>() { new Rest(), new Snore() },
			[50] = new List<Move>() { new Thrash() },
			[57] = new List<Move>() { new Fling() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focuspunch(), new Frustration(), new Gunkshot(), new Hiddenpower(), new Hypervoice(), new Icepunch(), new Lastresort(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Bellydrum(), new Closecombat(), new Counter(), new Crosschop(), new Crunch(), new Doubleedge(), new Faketears(), new Metalclaw(), new Nightslash(), new Playrough(), new Seismictoss(), new Takedown(), new Yawn() };
		public override int Weight => 88;
		public override int ExpYield => 66;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}