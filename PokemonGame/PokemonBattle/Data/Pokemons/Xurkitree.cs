using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Xurkitree : Pokemon
{
	public override string Name => "Xurkitree";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
	public override Stats BaseStats => new Stats(83, 89, 71, 173, 71, 83);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wrap(), new Moves.Thundershock() },
		[5] = new List<Move>() { new Moves.Charge() },
		[10] = new List<Move>() { new Moves.Thunderwave() },
		[15] = new List<Move>() { new Moves.Ingrain() },
		[20] = new List<Move>() { new Moves.Spark() },
		[25] = new List<Move>() { new Moves.Shockwave() },
		[30] = new List<Move>() { new Moves.Hypnosis() },
		[35] = new List<Move>() { new Moves.Eerieimpulse() },
		[40] = new List<Move>() { new Moves.Thunderpunch() },
		[45] = new List<Move>() { new Moves.Discharge() },
		[50] = new List<Move>() { new Moves.Magnetrise() },
		[55] = new List<Move>() { new Moves.Thunderbolt() },
		[60] = new List<Move>() { new Moves.Electricterrain() },
		[65] = new List<Move>() { new Moves.Powerwhip() },
		[70] = new List<Move>() { new Moves.Zapcannon() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 1000;
	public override int ExpYield => 285;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}