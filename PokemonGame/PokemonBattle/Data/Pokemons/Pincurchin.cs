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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Electricsurge() };
		public override Stats BaseStats => new Stats(48, 101, 95, 91, 85, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Thundershock() },
			[5] = new List<Move>() { new Moves.Watergun() },
			[10] = new List<Move>() { new Moves.Charge() },
			[15] = new List<Move>() { new Moves.Furyattack() },
			[20] = new List<Move>() { new Moves.Spark() },
			[25] = new List<Move>() { new Moves.Bubblebeam() },
			[30] = new List<Move>() { new Moves.Recover() },
			[35] = new List<Move>() { new Moves.Curse() },
			[40] = new List<Move>() { new Moves.Electricterrain() },
			[45] = new List<Move>() { new Moves.Poisonjab() },
			[50] = new List<Move>() { new Moves.Zingzap() },
			[55] = new List<Move>() { new Moves.Acupressure() },
			[60] = new List<Move>() { new Moves.Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Brine(), new Moves.Electricterrain(), new Moves.Endure(), new Moves.Facade(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Scald(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Substitute(), new Moves.Surf(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Memento(), new Moves.Suckerpunch() };
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