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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Strongjaw(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
		public override Stats BaseStats => new Stats(90, 115, 90, 48, 68, 74);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Rocktomb() },
			[1] = new List<Move>() { new Moves.Rocktomb(), new Moves.Razorshell(), new Moves.Crunch(), new Moves.Rockpolish(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Bite(), new Moves.Protect() },
			[21] = new List<Move>() { new Moves.Headbutt() },
			[30] = new List<Move>() { new Moves.Counter() },
			[39] = new List<Move>() { new Moves.Jawlock() },
			[48] = new List<Move>() { new Moves.Liquidation() },
			[57] = new List<Move>() { new Moves.Bodyslam() },
			[66] = new List<Move>() { new Moves.Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dive(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Megahorn(), new Moves.Meteorbeam(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Razorshell(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Waterfall(), new Moves.Whirlpool() };
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