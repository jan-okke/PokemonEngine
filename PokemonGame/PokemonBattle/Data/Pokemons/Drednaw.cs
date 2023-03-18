using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drednaw : Pokemon
	{
		public override string Name => "Drednaw";
		public override List<Ability> AvailableAbilities => new() {new Strongjaw(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(90, 115, 90, 48, 68, 74);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Rocktomb() },
			[1] = new List<Move>() { new Rocktomb(), new Razorshell(), new Crunch(), new Rockpolish(), new Tackle(), new Watergun(), new Bite(), new Protect() },
			[21] = new List<Move>() { new Headbutt() },
			[30] = new List<Move>() { new Counter() },
			[39] = new List<Move>() { new Jawlock() },
			[48] = new List<Move>() { new Liquidation() },
			[57] = new List<Move>() { new Bodyslam() },
			[66] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Crunch(), new Dig(), new Dive(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Gigaimpact(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Irondefense(), new Irontail(), new Liquidation(), new Megahorn(), new Meteorbeam(), new Muddywater(), new Mudshot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Revenge(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scald(), new Scaleshot(), new Scaryface(), new Skittersmack(), new Sleeptalk(), new Smartstrike(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Surf(), new Swordsdance(), new Throatchop(), new Waterfall(), new Whirlpool() };
		public override int Weight => 1155;
		public override int ExpYield => 170;
		public override int CatchRate => 75;
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