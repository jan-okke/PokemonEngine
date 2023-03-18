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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Schooling() };
		public override Stats BaseStats => new Stats(45, 20, 20, 25, 25, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Watergun(), new Moves.Growl() },
			[4] = new List<Move>() { new Moves.Helpinghand() },
			[8] = new List<Move>() { new Moves.Beatup() },
			[12] = new List<Move>() { new Moves.Brine() },
			[16] = new List<Move>() { new Moves.Tearfullook() },
			[20] = new List<Move>() { new Moves.Dive() },
			[24] = new List<Move>() { new Moves.Soak() },
			[28] = new List<Move>() { new Moves.Uproar() },
			[32] = new List<Move>() { new Moves.Aquatail() },
			[36] = new List<Move>() { new Moves.Aquaring() },
			[40] = new List<Move>() { new Moves.Endeavor() },
			[44] = new List<Move>() { new Moves.Hydropump() },
			[48] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterfall(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Mist(), new Moves.Takedown(), new Moves.Waterpulse() };
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