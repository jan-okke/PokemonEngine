using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klang : Pokemon
	{
		public override string Name => "Klang";
		public override List<Ability> AvailableAbilities => new() {new Plus(), new Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(60, 80, 95, 50, 70, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thundershock(), new Visegrip(), new Bind(), new Charge() },
			[12] = new List<Move>() { new Chargebeam() },
			[16] = new List<Move>() { new Metalsound() },
			[20] = new List<Move>() { new Autotomize() },
			[24] = new List<Move>() { new Discharge() },
			[28] = new List<Move>() { new Screech() },
			[32] = new List<Move>() { new Geargrind() },
			[36] = new List<Move>() { new Lockon() },
			[42] = new List<Move>() { new Shiftgear() },
			[48] = new List<Move>() { new Zapcannon() },
			[54] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Assurance(), new Endure(), new Facade(), new Flashcannon(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Powergem(), new Protect(), new Rest(), new Risingvoltage(), new Round(), new Sandstorm(), new Screech(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelroller(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 510;
		public override int ExpYield => 154;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}