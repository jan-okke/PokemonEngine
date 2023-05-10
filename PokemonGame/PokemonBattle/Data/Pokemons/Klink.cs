using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Klink : Pokemon
{
	public override string Name => "Klink";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Plus(), new Abilities.Minus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Clearbody() };
	public override Stats BaseStats => new Stats(40, 55, 70, 45, 60, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thundershock(), new Moves.Visegrip() },
		[4] = new List<Move>() { new Moves.Bind() },
		[8] = new List<Move>() { new Moves.Charge() },
		[12] = new List<Move>() { new Moves.Chargebeam() },
		[16] = new List<Move>() { new Moves.Metalsound() },
		[20] = new List<Move>() { new Moves.Autotomize() },
		[24] = new List<Move>() { new Moves.Discharge() },
		[28] = new List<Move>() { new Moves.Screech() },
		[32] = new List<Move>() { new Moves.Geargrind() },
		[36] = new List<Move>() { new Moves.Lockon() },
		[40] = new List<Move>() { new Moves.Shiftgear() },
		[44] = new List<Move>() { new Moves.Zapcannon() },
		[48] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Powergem(), new Moves.Protect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 210;
	public override int ExpYield => 60;
	public override int CatchRate => 130;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}