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
		public override List<Ability> AvailableAbilities => new() {new Cheekpouch(), new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Plus() };
		public override Stats BaseStats => new Stats(67, 58, 57, 81, 67, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nuzzle(), new Tailwhip() },
			[5] = new List<Move>() { new Tackle() },
			[10] = new List<Move>() { new Charge() },
			[15] = new List<Move>() { new Thundershock() },
			[20] = new List<Move>() { new Charm() },
			[25] = new List<Move>() { new Paraboliccharge() },
			[30] = new List<Move>() { new Voltswitch() },
			[35] = new List<Move>() { new Rest(), new Snore() },
			[40] = new List<Move>() { new Discharge() },
			[45] = new List<Move>() { new Playrough() },
			[50] = new List<Move>() { new Superfang() },
			[55] = new List<Move>() { new Entrainment() },
			[60] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Charm(), new Dazzlinggleam(), new Dig(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Fling(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uturn(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Covet(), new Magnetrise(), new Tearfullook() };
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