using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Beautifly : Pokemon
{
	public override string Name => "Beautifly";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rivalry() };
	public override Stats BaseStats => new Stats(60, 70, 50, 100, 50, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Gust() },
		[1] = new List<Move>() { new Moves.Gust() },
		[12] = new List<Move>() { new Moves.Absorb() },
		[15] = new List<Move>() { new Moves.Stunspore() },
		[17] = new List<Move>() { new Moves.Morningsun() },
		[20] = new List<Move>() { new Moves.Aircutter() },
		[22] = new List<Move>() { new Moves.Megadrain() },
		[25] = new List<Move>() { new Moves.Leechlife() },
		[27] = new List<Move>() { new Moves.Attract() },
		[30] = new List<Move>() { new Moves.Whirlwind() },
		[32] = new List<Move>() { new Moves.Gigadrain() },
		[35] = new List<Move>() { new Moves.Bugbuzz() },
		[37] = new List<Move>() { new Moves.Protect() },
		[40] = new List<Move>() { new Moves.Quiverdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Laserfocus(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uturn(), new Moves.Venoshock() };
	public override int Weight => 284;
	public override int ExpYield => 198;
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