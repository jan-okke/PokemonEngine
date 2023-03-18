using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wishiwashi : Pokemon
	{
		public override string Name => "Wishiwashi";
		public override List<Ability> AvailableAbilities => new() {new Schooling() };
		public override Stats BaseStats => new Stats(45, 20, 20, 40, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Growl() },
			[4] = new List<Move>() { new Helpinghand() },
			[8] = new List<Move>() { new Beatup() },
			[12] = new List<Move>() { new Brine() },
			[16] = new List<Move>() { new Tearfullook() },
			[20] = new List<Move>() { new Dive() },
			[24] = new List<Move>() { new Soak() },
			[28] = new List<Move>() { new Uproar() },
			[32] = new List<Move>() { new Aquatail() },
			[36] = new List<Move>() { new Aquaring() },
			[40] = new List<Move>() { new Endeavor() },
			[44] = new List<Move>() { new Hydropump() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Brine(), new Bulldoze(), new Dive(), new Earthquake(), new Endure(), new Facade(), new Flipturn(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Irontail(), new Liquidation(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Uproar(), new Uturn(), new Waterfall(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Mist(), new Takedown(), new Waterpulse() };
		public override int Weight => 3;
		public override int ExpYield => 61;
		public override int CatchRate => 60;
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