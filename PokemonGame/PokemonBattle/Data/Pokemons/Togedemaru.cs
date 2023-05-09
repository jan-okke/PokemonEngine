using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Togedemaru : Pokemon
{
	public override string Name => "Togedemaru";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ironbarbs(), new Abilities.Lightningrod() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sturdy() };
	public override Stats BaseStats => new Stats(65, 98, 63, 40, 73, 96);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Steel };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Nuzzle(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Defensecurl() },
		[10] = new List<Move>() { new Moves.Charge() },
		[15] = new List<Move>() { new Moves.Thundershock() },
		[20] = new List<Move>() { new Moves.Fellstinger() },
		[25] = new List<Move>() { new Moves.Spark() },
		[30] = new List<Move>() { new Moves.Pinmissile() },
		[35] = new List<Move>() { new Moves.Magnetrise() },
		[40] = new List<Move>() { new Moves.Zingzap() },
		[45] = new List<Move>() { new Moves.Discharge() },
		[50] = new List<Move>() { new Moves.Electricterrain() },
		[55] = new List<Move>() { new Moves.Wildcharge() },
		[60] = new List<Move>() { new Moves.Spikyshield() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Disarmingvoice(), new Moves.Fakeout(), new Moves.Flail(), new Moves.Present(), new Moves.Tickle(), new Moves.Wish() };
	public override int Weight => 33;
	public override int ExpYield => 152;
	public override int CatchRate => 180;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}