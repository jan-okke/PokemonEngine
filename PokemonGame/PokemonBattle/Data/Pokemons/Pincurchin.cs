using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pincurchin : Pokemon
	{
		public override string Name => "Pincurchin";
		public override List<Ability> AvailableAbilities => new() {new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Electricsurge() };
		public override Stats BaseStats => new Stats(48, 101, 95, 91, 85, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Thundershock() },
			[5] = new List<Move>() { new Watergun() },
			[10] = new List<Move>() { new Charge() },
			[15] = new List<Move>() { new Furyattack() },
			[20] = new List<Move>() { new Spark() },
			[25] = new List<Move>() { new Bubblebeam() },
			[30] = new List<Move>() { new Recover() },
			[35] = new List<Move>() { new Curse() },
			[40] = new List<Move>() { new Electricterrain() },
			[45] = new List<Move>() { new Poisonjab() },
			[50] = new List<Move>() { new Zingzap() },
			[55] = new List<Move>() { new Acupressure() },
			[60] = new List<Move>() { new Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Brine(), new Electricterrain(), new Endure(), new Facade(), new Hex(), new Hiddenpower(), new Hydropump(), new Liquidation(), new Muddywater(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Reversal(), new Risingvoltage(), new Round(), new Scald(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Spikes(), new Substitute(), new Surf(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Memento(), new Suckerpunch() };
		public override int Weight => 10;
		public override int ExpYield => 152;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}