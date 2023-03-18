using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Finneon : Pokemon
	{
		public override string Name => "Finneon";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Stormdrain() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(49, 49, 56, 66, 49, 61);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound() },
			[6] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Attract() },
			[13] = new List<Move>() { new Raindance() },
			[17] = new List<Move>() { new Gust() },
			[22] = new List<Move>() { new Waterpulse() },
			[26] = new List<Move>() { new Flail() },
			[29] = new List<Move>() { new Safeguard() },
			[33] = new List<Move>() { new Aquaring() },
			[38] = new List<Move>() { new Whirlpool() },
			[42] = new List<Move>() { new Uturn() },
			[45] = new List<Move>() { new Bounce() },
			[49] = new List<Move>() { new Tailwind() },
			[54] = new List<Move>() { new Soak() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Confide(), new Defog(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Flash(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Naturepower(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Tailwind(), new Uturn(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Aquatail(), new Aurorabeam(), new Charm(), new Confuseray(), new Flail(), new Psybeam(), new Splash(), new Sweetkiss(), new Tickle() };
		public override int Weight => 70;
		public override int ExpYield => 66;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}