using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wooper : Pokemon
	{
		public override string Name => "Wooper";
		public override List<Ability> AvailableAbilities => new() {new Damp(), new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(55, 45, 45, 25, 25, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Tailwhip() },
			[4] = new List<Move>() { new Raindance() },
			[8] = new List<Move>() { new Mudshot() },
			[12] = new List<Move>() { new Mist(), new Haze() },
			[16] = new List<Move>() { new Slam() },
			[21] = new List<Move>() { new Yawn() },
			[24] = new List<Move>() { new Aquatail() },
			[28] = new List<Move>() { new Muddywater() },
			[32] = new List<Move>() { new Amnesia() },
			[36] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Earthquake() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Eerieimpulse(), new Encore(), new Endure(), new Facade(), new Flash(), new Guardswap(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Safeguard(), new Sandstorm(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stompingtantrum(), new Substitute(), new Surf(), new Swagger(), new Toxic(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Afteryou(), new Ancientpower(), new Bodyslam(), new Counter(), new Curse(), new Doublekick(), new Eerieimpulse(), new Encore(), new Guardswap(), new Poweruppunch(), new Recover(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 85;
		public override int ExpYield => 42;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}