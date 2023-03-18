using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klink : Pokemon
	{
		public override string Name => "Klink";
		public override List<Ability> AvailableAbilities => new() {new Plus(), new Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(40, 55, 70, 30, 45, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Visegrip() },
			[4] = new List<Move>() { new Bind() },
			[8] = new List<Move>() { new Charge() },
			[12] = new List<Move>() { new Chargebeam() },
			[16] = new List<Move>() { new Metalsound() },
			[20] = new List<Move>() { new Autotomize() },
			[24] = new List<Move>() { new Discharge() },
			[28] = new List<Move>() { new Screech() },
			[32] = new List<Move>() { new Geargrind() },
			[36] = new List<Move>() { new Lockon() },
			[40] = new List<Move>() { new Shiftgear() },
			[44] = new List<Move>() { new Zapcannon() },
			[48] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Endure(), new Facade(), new Flashcannon(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Powergem(), new Protect(), new Rest(), new Risingvoltage(), new Round(), new Sandstorm(), new Screech(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelroller(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 210;
		public override int ExpYield => 60;
		public override int CatchRate => 130;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}