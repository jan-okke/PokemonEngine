using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Doduo : Pokemon
{
	public override string Name => "Doduo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Earlybird() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tangledfeet() };
	public override Stats BaseStats => new Stats(35, 85, 45, 35, 35, 75);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Growl() },
		[5] = new List<Move>() { new Moves.Quickattack() },
		[8] = new List<Move>() { new Moves.Leer() },
		[12] = new List<Move>() { new Moves.Furyattack() },
		[15] = new List<Move>() { new Moves.Wingattack() },
		[19] = new List<Move>() { new Moves.Pluck() },
		[22] = new List<Move>() { new Moves.Doublehit() },
		[26] = new List<Move>() { new Moves.Agility() },
		[29] = new List<Move>() { new Moves.Uproar() },
		[33] = new List<Move>() { new Moves.Acupressure() },
		[36] = new List<Move>() { new Moves.Swordsdance() },
		[40] = new List<Move>() { new Moves.Lunge() },
		[43] = new List<Move>() { new Moves.Drillpeck() },
		[47] = new List<Move>() { new Moves.Endeavor() },
		[50] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Knockoff(), new Moves.Pluck(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Uproar(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Bravebird(), new Moves.Endeavor(), new Moves.Flail(), new Moves.Haze(), new Moves.Quickattack(), new Moves.Supersonic() };
	public override int Weight => 392;
	public override int ExpYield => 62;
	public override int CatchRate => 190;
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