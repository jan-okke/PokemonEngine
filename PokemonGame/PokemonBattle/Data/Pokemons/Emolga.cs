using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Emolga : Pokemon
{
	public override string Name => "Emolga";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Motordrive() };
	public override Stats BaseStats => new Stats(55, 75, 60, 75, 60, 103);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Nuzzle(), new Moves.Tailwhip() },
		[5] = new List<Move>() { new Moves.Doubleteam() },
		[10] = new List<Move>() { new Moves.Quickattack() },
		[15] = new List<Move>() { new Moves.Thundershock() },
		[20] = new List<Move>() { new Moves.Charge() },
		[25] = new List<Move>() { new Moves.Acrobatics() },
		[30] = new List<Move>() { new Moves.Spark() },
		[35] = new List<Move>() { new Moves.Encore() },
		[40] = new List<Move>() { new Moves.Voltswitch() },
		[45] = new List<Move>() { new Moves.Lightscreen() },
		[50] = new List<Move>() { new Moves.Discharge() },
		[55] = new List<Move>() { new Moves.Agility() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Charm(), new Moves.Dualwingbeat(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Covet(), new Moves.Defog(), new Moves.Roost(), new Moves.Shockwave(), new Moves.Tickle() };
	public override int Weight => 50;
	public override int ExpYield => 150;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}