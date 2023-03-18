using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ursaring : Pokemon
	{
		public override string Name => "Ursaring";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(90, 130, 75, 55, 75, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Hammerarm(), new Covet(), new Scratch(), new Leer(), new Lick(), new Faketears() },
			[8] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Payback() },
			[22] = new List<Move>() { new Sweetscent() },
			[25] = new List<Move>() { new Playnice() },
			[29] = new List<Move>() { new Slash() },
			[38] = new List<Move>() { new Scaryface() },
			[47] = new List<Move>() { new Rest() },
			[49] = new List<Move>() { new Snore() },
			[58] = new List<Move>() { new Thrash() },
			[67] = new List<Move>() { new Hammerarm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Avalanche(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Covet(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Gunkshot(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Laserfocus(), new Lastresort(), new Lowkick(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Smackdown(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Torment(), new Uproar(), new Workup() };
		public override int Weight => 1258;
		public override int ExpYield => 175;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}