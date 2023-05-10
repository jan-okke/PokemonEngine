using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Arrokuda : Pokemon
{
	public override string Name => "Arrokuda";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Propellertail() };
	public override Stats BaseStats => new Stats(41, 63, 40, 40, 30, 66);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Aquajet() },
		[6] = new List<Move>() { new Moves.Furyattack() },
		[12] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Agility() },
		[24] = new List<Move>() { new Moves.Dive() },
		[30] = new List<Move>() { new Moves.Laserfocus() },
		[36] = new List<Move>() { new Moves.Crunch() },
		[42] = new List<Move>() { new Moves.Liquidation() },
		[48] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Dive(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Icefang(), new Moves.Liquidation(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Throatchop(), new Moves.Waterfall(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acupressure(), new Moves.Nightslash(), new Moves.Slash(), new Moves.Thrash() };
	public override int Weight => 10;
	public override int ExpYield => 56;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}