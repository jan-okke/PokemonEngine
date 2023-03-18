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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Plus(), new Abilities.Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Clearbody() };
		public override Stats BaseStats => new Stats(60, 100, 115, 70, 85, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Gearup(), new Moves.Magneticflux(), new Moves.Thundershock(), new Moves.Visegrip(), new Moves.Bind(), new Moves.Charge() },
			[12] = new List<Move>() { new Moves.Chargebeam() },
			[16] = new List<Move>() { new Moves.Metalsound() },
			[20] = new List<Move>() { new Moves.Autotomize() },
			[24] = new List<Move>() { new Moves.Discharge() },
			[28] = new List<Move>() { new Moves.Screech() },
			[32] = new List<Move>() { new Moves.Geargrind() },
			[36] = new List<Move>() { new Moves.Lockon() },
			[42] = new List<Move>() { new Moves.Shiftgear() },
			[48] = new List<Move>() { new Moves.Zapcannon() },
			[56] = new List<Move>() { new Moves.Hyperbeam() },
			[64] = new List<Move>() { new Moves.Electricterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Electricterrain(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Powergem(), new Moves.Protect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
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