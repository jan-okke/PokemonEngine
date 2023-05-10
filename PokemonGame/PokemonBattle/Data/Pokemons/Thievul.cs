using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Thievul : Pokemon
{
	public override string Name => "Thievul";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Unburden() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stakeout() };
	public override Stats BaseStats => new Stats(70, 58, 58, 87, 92, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thief() },
		[1] = new List<Move>() { new Moves.Thief(), new Moves.Quickattack(), new Moves.Tailwhip(), new Moves.Beatup(), new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Snarl() },
		[16] = new List<Move>() { new Moves.Assurance() },
		[22] = new List<Move>() { new Moves.Nastyplot() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[34] = new List<Move>() { new Moves.Nightslash() },
		[40] = new List<Move>() { new Moves.Tailslap() },
		[46] = new List<Move>() { new Moves.Foulplay() },
		[52] = new List<Move>() { new Moves.Partingshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Beatup(), new Moves.Burningjealousy(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firefang(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Lashout(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderfang(), new Moves.Uturn() };
	public override int Weight => 199;
	public override int ExpYield => 159;
	public override int CatchRate => 127;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}