using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sobble : Pokemon
	{
		public override string Name => "Sobble";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(50, 40, 40, 70, 70, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Growl() },
			[6] = new List<Move>() { new Watergun() },
			[8] = new List<Move>() { new Bind() },
			[12] = new List<Move>() { new Waterpulse() },
			[17] = new List<Move>() { new Tearfullook() },
			[20] = new List<Move>() { new Suckerpunch() },
			[24] = new List<Move>() { new Uturn() },
			[28] = new List<Move>() { new Liquidation() },
			[32] = new List<Move>() { new Soak() },
			[36] = new List<Move>() { new Raindance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bounce(), new Dive(), new Endure(), new Facade(), new Hiddenpower(), new Lightscreen(), new Liquidation(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swift(), new Uturn(), new Waterpledge(), new Weatherball(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aquajet(), new Aquaring(), new Doubleteam(), new Fellstinger(), new Haze(), new Iceshard(), new Mist() };
		public override int Weight => 40;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 1
		};
	}
}