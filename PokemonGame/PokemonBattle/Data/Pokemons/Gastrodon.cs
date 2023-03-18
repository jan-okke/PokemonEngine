using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gastrodon : Pokemon
	{
		public override string Name => "Gastrodon";
		public override List<Ability> AvailableAbilities => new() {new Stickyhold(), new Stormdrain() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandforce() };
		public override Stats BaseStats => new Stats(111, 83, 68, 39, 92, 82);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Mudslap(), new Harden(), new Recover() },
			[15] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Bodyslam() },
			[33] = new List<Move>() { new Muddywater() },
			[39] = new List<Move>() { new Earthpower() },
			[46] = new List<Move>() { new Raindance() },
			[53] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Flash(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scald(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool() };
		public override int Weight => 299;
		public override int ExpYield => 166;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}