using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Luvdisc : Pokemon
	{
		public override string Name => "Luvdisc";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(43, 30, 55, 97, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Charm() },
			[4] = new List<Move>() { new Watergun() },
			[7] = new List<Move>() { new Agility() },
			[9] = new List<Move>() { new Drainingkiss() },
			[13] = new List<Move>() { new Tearfullook() },
			[17] = new List<Move>() { new Waterpulse() },
			[20] = new List<Move>() { new Attract() },
			[22] = new List<Move>() { new Brine() },
			[26] = new List<Move>() { new Flail() },
			[31] = new List<Move>() { new Sweetkiss() },
			[34] = new List<Move>() { new Takedown() },
			[37] = new List<Move>() { new Babydolleyes() },
			[40] = new List<Move>() { new Aquaring() },
			[42] = new List<Move>() { new Soak() },
			[46] = new List<Move>() { new Hydropump() },
			[49] = new List<Move>() { new Safeguard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bounce(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Liquidation(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Aquajet(), new Aquaring(), new Entrainment(), new Healpulse(), new Splash(), new Supersonic() };
		public override int Weight => 87;
		public override int ExpYield => 116;
		public override int CatchRate => 225;
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