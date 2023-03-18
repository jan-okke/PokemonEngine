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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Honeygather() };
		public override Stats BaseStats => new Stats(60, 80, 50, 50, 50, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Fling(), new Moves.Covet(), new Moves.Scratch(), new Moves.Babydolleyes(), new Moves.Lick(), new Moves.Faketears() },
			[8] = new List<Move>() { new Moves.Furyswipes() },
			[15] = new List<Move>() { new Moves.Payback() },
			[22] = new List<Move>() { new Moves.Sweetscent() },
			[25] = new List<Move>() { new Moves.Playnice() },
			[29] = new List<Move>() { new Moves.Slash() },
			[36] = new List<Move>() { new Moves.Charm() },
			[43] = new List<Move>() { new Moves.Rest(), new Moves.Snore() },
			[50] = new List<Move>() { new Moves.Thrash() },
			[57] = new List<Move>() { new Moves.Fling() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Lastresort(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bellydrum(), new Moves.Closecombat(), new Moves.Counter(), new Moves.Crosschop(), new Moves.Crunch(), new Moves.Doubleedge(), new Moves.Faketears(), new Moves.Metalclaw(), new Moves.Nightslash(), new Moves.Playrough(), new Moves.Seismictoss(), new Moves.Takedown(), new Moves.Yawn() };
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