using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Wooloo : Pokemon
{
	public override string Name => "Wooloo";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Fluffy(), new Abilities.Runaway() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bulletproof() };
	public override Stats BaseStats => new Stats(42, 40, 55, 40, 45, 48);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Defensecurl() },
		[8] = new List<Move>() { new Moves.Copycat() },
		[12] = new List<Move>() { new Moves.Guardsplit() },
		[16] = new List<Move>() { new Moves.Doublekick() },
		[21] = new List<Move>() { new Moves.Headbutt() },
		[25] = new List<Move>() { new Moves.Takedown() },
		[28] = new List<Move>() { new Moves.Guardswap() },
		[32] = new List<Move>() { new Moves.Reversal() },
		[36] = new List<Move>() { new Moves.Cottonguard() },
		[40] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Grassyglide(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thunderwave(), new Moves.Wildcharge() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Stomp(), new Moves.Swagger() };
	public override int Weight => 60;
	public override int ExpYield => 122;
	public override int CatchRate => 255;
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