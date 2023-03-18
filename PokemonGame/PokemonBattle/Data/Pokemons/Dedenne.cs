using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dedenne : Pokemon
	{
		public override string Name => "Dedenne";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cheekpouch(), new Abilities.Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Plus() };
		public override Stats BaseStats => new Stats(67, 58, 57, 81, 67, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Nuzzle(), new Moves.Tailwhip() },
			[5] = new List<Move>() { new Moves.Tackle() },
			[10] = new List<Move>() { new Moves.Charge() },
			[15] = new List<Move>() { new Moves.Thundershock() },
			[20] = new List<Move>() { new Moves.Charm() },
			[25] = new List<Move>() { new Moves.Paraboliccharge() },
			[30] = new List<Move>() { new Moves.Voltswitch() },
			[35] = new List<Move>() { new Moves.Rest(), new Moves.Snore() },
			[40] = new List<Move>() { new Moves.Discharge() },
			[45] = new List<Move>() { new Moves.Playrough() },
			[50] = new List<Move>() { new Moves.Superfang() },
			[55] = new List<Move>() { new Moves.Entrainment() },
			[60] = new List<Move>() { new Moves.Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Covet(), new Moves.Magnetrise(), new Moves.Tearfullook() };
		public override int Weight => 22;
		public override int ExpYield => 151;
		public override int CatchRate => 180;
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