using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Dustox : Pokemon
{
	public override string Name => "Dustox";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Shielddust() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Compoundeyes() };
	public override Stats BaseStats => new Stats(60, 50, 70, 50, 90, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Gust() },
		[1] = new List<Move>() { new Moves.Gust() },
		[12] = new List<Move>() { new Moves.Confusion() },
		[15] = new List<Move>() { new Moves.Poisonpowder() },
		[17] = new List<Move>() { new Moves.Moonlight() },
		[20] = new List<Move>() { new Moves.Venoshock() },
		[22] = new List<Move>() { new Moves.Psybeam() },
		[25] = new List<Move>() { new Moves.Leechlife() },
		[27] = new List<Move>() { new Moves.Lightscreen() },
		[30] = new List<Move>() { new Moves.Whirlwind() },
		[32] = new List<Move>() { new Moves.Toxic() },
		[35] = new List<Move>() { new Moves.Bugbuzz() },
		[37] = new List<Move>() { new Moves.Protect() },
		[40] = new List<Move>() { new Moves.Quiverdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Infestation(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Venoshock() };
	public override int Weight => 316;
	public override int ExpYield => 193;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}