using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lumineon : Pokemon
	{
		public override string Name => "Lumineon";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Stormdrain() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(69, 69, 76, 91, 69, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Soak(), new Gust(), new Pound(), new Watergun(), new Attract() },
			[6] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Attract() },
			[13] = new List<Move>() { new Raindance() },
			[17] = new List<Move>() { new Gust() },
			[22] = new List<Move>() { new Waterpulse() },
			[26] = new List<Move>() { new Flail() },
			[29] = new List<Move>() { new Safeguard() },
			[35] = new List<Move>() { new Aquaring() },
			[42] = new List<Move>() { new Whirlpool() },
			[48] = new List<Move>() { new Uturn() },
			[53] = new List<Move>() { new Bounce() },
			[59] = new List<Move>() { new Tailwind() },
			[66] = new List<Move>() { new Soak() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Confide(), new Defog(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Frustration(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Tailwind(), new Uturn(), new Waterfall(), new Waterpulse() };
		public override int Weight => 240;
		public override int ExpYield => 161;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}