using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bronzor : Pokemon
{
	public override string Name => "Bronzor";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate(), new Abilities.Heatproof() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Heavymetal() };
	public override Stats BaseStats => new Stats(57, 24, 86, 24, 86, 23);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Confusion() },
		[4] = new List<Move>() { new Moves.Confuseray() },
		[8] = new List<Move>() { new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Imprison() },
		[16] = new List<Move>() { new Moves.Gyroball() },
		[20] = new List<Move>() { new Moves.Hypnosis() },
		[24] = new List<Move>() { new Moves.Safeguard() },
		[28] = new List<Move>() { new Moves.Extrasensory() },
		[32] = new List<Move>() { new Moves.Heavyslam() },
		[36] = new List<Move>() { new Moves.Irondefense() },
		[40] = new List<Move>() { new Moves.Metalsound() },
		[44] = new List<Move>() { new Moves.Futuresight() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Speedswap(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom() };
	public override int Weight => 605;
	public override int ExpYield => 60;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}