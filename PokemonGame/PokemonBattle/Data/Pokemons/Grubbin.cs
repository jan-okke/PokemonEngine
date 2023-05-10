using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Grubbin : Pokemon
{
	public override string Name => "Grubbin";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm() };
	public override Stats BaseStats => new Stats(47, 62, 45, 55, 45, 46);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Visegrip(), new Moves.Mudslap() },
		[5] = new List<Move>() { new Moves.Stringshot() },
		[10] = new List<Move>() { new Moves.Bugbite() },
		[15] = new List<Move>() { new Moves.Bite() },
		[21] = new List<Move>() { new Moves.Spark() },
		[25] = new List<Move>() { new Moves.Stickyweb() },
		[30] = new List<Move>() { new Moves.Xscissor() },
		[35] = new List<Move>() { new Moves.Crunch() },
		[40] = new List<Move>() { new Moves.Dig() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Crunch(), new Moves.Dig(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Lightscreen(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Xscissor() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Discharge(), new Moves.Harden() };
	public override int Weight => 44;
	public override int ExpYield => 60;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}