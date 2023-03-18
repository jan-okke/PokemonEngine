using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drizzile : Pokemon
	{
		public override string Name => "Drizzile";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(65, 60, 55, 90, 95, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Growl(), new Watergun(), new Bind() },
			[12] = new List<Move>() { new Waterpulse() },
			[19] = new List<Move>() { new Tearfullook() },
			[24] = new List<Move>() { new Suckerpunch() },
			[30] = new List<Move>() { new Uturn() },
			[36] = new List<Move>() { new Liquidation() },
			[42] = new List<Move>() { new Soak() },
			[48] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bounce(), new Dive(), new Endure(), new Facade(), new Fling(), new Hiddenpower(), new Lightscreen(), new Liquidation(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swift(), new Uturn(), new Waterpledge(), new Weatherball(), new Whirlpool(), new Workup() };
		public override int Weight => 115;
		public override int ExpYield => 147;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}