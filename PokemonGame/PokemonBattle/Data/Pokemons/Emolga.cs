using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Emolga : Pokemon
	{
		public override string Name => "Emolga";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Motordrive() };
		public override Stats BaseStats => new Stats(55, 75, 60, 103, 75, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Nuzzle(), new Tailwhip() },
			[5] = new List<Move>() { new Doubleteam() },
			[10] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Thundershock() },
			[20] = new List<Move>() { new Charge() },
			[25] = new List<Move>() { new Acrobatics() },
			[30] = new List<Move>() { new Spark() },
			[35] = new List<Move>() { new Encore() },
			[40] = new List<Move>() { new Voltswitch() },
			[45] = new List<Move>() { new Lightscreen() },
			[50] = new List<Move>() { new Discharge() },
			[55] = new List<Move>() { new Agility() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Attract(), new Batonpass(), new Charm(), new Dualwingbeat(), new Eerieimpulse(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Energyball(), new Facade(), new Fling(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Substitute(), new Swift(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uturn(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Covet(), new Defog(), new Roost(), new Shockwave(), new Tickle() };
		public override int Weight => 50;
		public override int ExpYield => 150;
		public override int CatchRate => 200;
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