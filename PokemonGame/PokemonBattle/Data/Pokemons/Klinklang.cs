using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Klinklang : Pokemon
	{
		public override string Name => "Klinklang";
		public override List<Ability> AvailableAbilities => new() {new Plus(), new Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(60, 100, 115, 90, 70, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gearup(), new Magneticflux(), new Thundershock(), new Visegrip(), new Bind(), new Charge() },
			[12] = new List<Move>() { new Chargebeam() },
			[16] = new List<Move>() { new Metalsound() },
			[20] = new List<Move>() { new Autotomize() },
			[24] = new List<Move>() { new Discharge() },
			[28] = new List<Move>() { new Screech() },
			[32] = new List<Move>() { new Geargrind() },
			[36] = new List<Move>() { new Lockon() },
			[42] = new List<Move>() { new Shiftgear() },
			[48] = new List<Move>() { new Zapcannon() },
			[56] = new List<Move>() { new Hyperbeam() },
			[64] = new List<Move>() { new Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Assurance(), new Electricterrain(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Powergem(), new Protect(), new Rest(), new Risingvoltage(), new Round(), new Sandstorm(), new Screech(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelroller(), new Substitute(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trickroom(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 810;
		public override int ExpYield => 260;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}