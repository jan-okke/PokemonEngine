using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Malamar : Pokemon
{
	public override string Name => "Malamar";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Contrary(), new Abilities.Suctioncups() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(86, 92, 88, 68, 75, 73);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Reversal(), new Moves.Peck(), new Moves.Tackle(), new Moves.Hypnosis(), new Moves.Wrap() },
		[9] = new List<Move>() { new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Pluck() },
		[15] = new List<Move>() { new Moves.Psybeam() },
		[18] = new List<Move>() { new Moves.Swagger() },
		[21] = new List<Move>() { new Moves.Slash() },
		[24] = new List<Move>() { new Moves.Nightslash() },
		[27] = new List<Move>() { new Moves.Psychocut() },
		[33] = new List<Move>() { new Moves.Switcheroo() },
		[37] = new List<Move>() { new Moves.Foulplay() },
		[42] = new List<Move>() { new Moves.Topsyturvy() },
		[47] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Brutalswing(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Guardswap(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lashout(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderbolt(), new Moves.Trickroom() };
	public override int Weight => 470;
	public override int ExpYield => 169;
	public override int CatchRate => 80;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}