using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Pidgeotto : Pokemon
{
	public override string Name => "Pidgeotto";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Tangledfeet() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bigpecks() };
	public override Stats BaseStats => new Stats(63, 60, 55, 50, 50, 71);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Sandattack(), new Moves.Gust() },
		[5] = new List<Move>() { new Moves.Sandattack() },
		[9] = new List<Move>() { new Moves.Gust() },
		[13] = new List<Move>() { new Moves.Quickattack() },
		[17] = new List<Move>() { new Moves.Whirlwind() },
		[22] = new List<Move>() { new Moves.Twister() },
		[27] = new List<Move>() { new Moves.Featherdance() },
		[32] = new List<Move>() { new Moves.Agility() },
		[37] = new List<Move>() { new Moves.Wingattack() },
		[42] = new List<Move>() { new Moves.Roost() },
		[47] = new List<Move>() { new Moves.Tailwind() },
		[52] = new List<Move>() { new Moves.Aerialace() },
		[57] = new List<Move>() { new Moves.Airslash() },
		[62] = new List<Move>() { new Moves.Hurricane() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 300;
	public override int ExpYield => 122;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}