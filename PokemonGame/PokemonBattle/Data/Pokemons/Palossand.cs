using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Palossand : Pokemon
{
	public override string Name => "Palossand";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Watercompaction() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandveil() };
	public override Stats BaseStats => new Stats(85, 75, 110, 100, 75, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Harden(), new Moves.Astonish(), new Moves.Sandtomb() },
		[15] = new List<Move>() { new Moves.Megadrain() },
		[20] = new List<Move>() { new Moves.Sandattack() },
		[25] = new List<Move>() { new Moves.Bulldoze() },
		[30] = new List<Move>() { new Moves.Hypnosis() },
		[35] = new List<Move>() { new Moves.Gigadrain() },
		[40] = new List<Move>() { new Moves.Irondefense() },
		[47] = new List<Move>() { new Moves.Shadowball() },
		[54] = new List<Move>() { new Moves.Earthpower() },
		[61] = new List<Move>() { new Moves.Shoreup() },
		[68] = new List<Move>() { new Moves.Sandstorm() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Mudshot(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Terrainpulse(), new Moves.Trick() };
	public override int Weight => 2500;
	public override int ExpYield => 168;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}