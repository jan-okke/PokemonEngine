using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Staravia : Pokemon
{
	public override string Name => "Staravia";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Reckless() };
	public override Stats BaseStats => new Stats(55, 75, 50, 40, 40, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl(), new Moves.Quickattack() },
		[5] = new List<Move>() { new Moves.Quickattack() },
		[9] = new List<Move>() { new Moves.Wingattack() },
		[13] = new List<Move>() { new Moves.Doubleteam() },
		[18] = new List<Move>() { new Moves.Endeavor() },
		[23] = new List<Move>() { new Moves.Whirlwind() },
		[28] = new List<Move>() { new Moves.Aerialace() },
		[33] = new List<Move>() { new Moves.Takedown() },
		[38] = new List<Move>() { new Moves.Agility() },
		[43] = new List<Move>() { new Moves.Bravebird() },
		[48] = new List<Move>() { new Moves.Finalgambit() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 155;
	public override int ExpYield => 119;
	public override int CatchRate => 120;
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