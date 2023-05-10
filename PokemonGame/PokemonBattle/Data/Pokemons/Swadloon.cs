using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Swadloon : Pokemon
{
	public override string Name => "Swadloon";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard(), new Abilities.Chlorophyll() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
	public override Stats BaseStats => new Stats(55, 63, 90, 50, 80, 42);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Protect() },
		[1] = new List<Move>() { new Moves.Protect(), new Moves.Grasswhistle(), new Moves.Tackle(), new Moves.Stringshot(), new Moves.Bugbite(), new Moves.Razorleaf() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bugbite(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Electroweb(), new Moves.Energyball(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Toxic(), new Moves.Worryseed() };
	public override int Weight => 73;
	public override int ExpYield => 133;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}