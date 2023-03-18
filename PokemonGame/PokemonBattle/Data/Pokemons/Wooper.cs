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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Damp(), new Abilities.Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unaware() };
		public override Stats BaseStats => new Stats(55, 45, 45, 25, 25, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Tailwhip() },
			[4] = new List<Move>() { new Moves.Raindance() },
			[8] = new List<Move>() { new Moves.Mudshot() },
			[12] = new List<Move>() { new Moves.Mist(), new Moves.Haze() },
			[16] = new List<Move>() { new Moves.Slam() },
			[21] = new List<Move>() { new Moves.Yawn() },
			[24] = new List<Move>() { new Moves.Aquatail() },
			[28] = new List<Move>() { new Moves.Muddywater() },
			[32] = new List<Move>() { new Moves.Amnesia() },
			[36] = new List<Move>() { new Moves.Toxic() },
			[40] = new List<Move>() { new Moves.Earthquake() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Eerieimpulse(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Guardswap(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Toxic(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Afteryou(), new Moves.Ancientpower(), new Moves.Bodyslam(), new Moves.Counter(), new Moves.Curse(), new Moves.Doublekick(), new Moves.Eerieimpulse(), new Moves.Encore(), new Moves.Guardswap(), new Moves.Poweruppunch(), new Moves.Recover(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
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