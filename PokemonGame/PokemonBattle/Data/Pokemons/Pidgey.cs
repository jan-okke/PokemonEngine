using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pidgey : Pokemon
{
	public override string Name => "Pidgey";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Tangledfeet() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bigpecks() };
	public override Stats BaseStats => new Stats(40, 45, 40, 35, 35, 56);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[9] = new List<Move>() { new Moves.Gust() },
		[13] = new List<Move>() { new Moves.Quickattack() },
		[17] = new List<Move>() { new Moves.Whirlwind() },
		[21] = new List<Move>() { new Moves.Twister() },
		[25] = new List<Move>() { new Moves.Featherdance() },
		[29] = new List<Move>() { new Moves.Agility() },
		[33] = new List<Move>() { new Moves.Wingattack() },
		[37] = new List<Move>() { new Moves.Roost() },
		[41] = new List<Move>() { new Moves.Tailwind() },
		[45] = new List<Move>() { new Moves.Aerialace() },
		[49] = new List<Move>() { new Moves.Airslash() },
		[53] = new List<Move>() { new Moves.Hurricane() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Aircutter(), new Moves.Airslash(), new Moves.Bravebird(), new Moves.Uproar() };
	public override int Weight => 18;
	public override int ExpYield => 50;
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