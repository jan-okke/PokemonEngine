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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Plus(), new Abilities.Minus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Clearbody() };
		public override Stats BaseStats => new Stats(60, 80, 95, 70, 85, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Visegrip(), new Moves.Bind(), new Moves.Charge() },
			[12] = new List<Move>() { new Moves.Chargebeam() },
			[16] = new List<Move>() { new Moves.Metalsound() },
			[20] = new List<Move>() { new Moves.Autotomize() },
			[24] = new List<Move>() { new Moves.Discharge() },
			[28] = new List<Move>() { new Moves.Screech() },
			[32] = new List<Move>() { new Moves.Geargrind() },
			[36] = new List<Move>() { new Moves.Lockon() },
			[42] = new List<Move>() { new Moves.Shiftgear() },
			[48] = new List<Move>() { new Moves.Zapcannon() },
			[54] = new List<Move>() { new Moves.Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Powergem(), new Moves.Protect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
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