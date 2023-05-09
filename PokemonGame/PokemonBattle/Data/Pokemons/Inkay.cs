using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Inkay : Pokemon
{
	public override string Name => "Inkay";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Contrary(), new Abilities.Suctioncups() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(53, 54, 53, 37, 46, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Hypnosis() },
		[6] = new List<Move>() { new Moves.Wrap() },
		[9] = new List<Move>() { new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Pluck() },
		[15] = new List<Move>() { new Moves.Psybeam() },
		[18] = new List<Move>() { new Moves.Swagger() },
		[21] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Nightslash() },
		[27] = new List<Move>() { new Moves.Psychocut() },
		[31] = new List<Move>() { new Moves.Switcheroo() },
		[33] = new List<Move>() { new Moves.Foulplay() },
		[36] = new List<Move>() { new Moves.Topsyturvy() },
		[39] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Lashout(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderbolt(), new Moves.Trickroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acupressure(), new Moves.Destinybond(), new Moves.Disable() };
	public override int Weight => 35;
	public override int ExpYield => 58;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}