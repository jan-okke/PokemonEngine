using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Nickit : Pokemon
{
	public override string Name => "Nickit";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Unburden() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Stakeout() };
	public override Stats BaseStats => new Stats(40, 28, 28, 47, 52, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Beatup() },
		[8] = new List<Move>() { new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Snarl() },
		[16] = new List<Move>() { new Moves.Assurance() },
		[20] = new List<Move>() { new Moves.Nastyplot() },
		[24] = new List<Move>() { new Moves.Suckerpunch() },
		[28] = new List<Move>() { new Moves.Nightslash() },
		[32] = new List<Move>() { new Moves.Tailslap() },
		[36] = new List<Move>() { new Moves.Foulplay() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Beatup(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Foulplay(), new Moves.Hiddenpower(), new Moves.Lashout(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Taunt(), new Moves.Thief() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Howl(), new Moves.Knockoff(), new Moves.Quickguard(), new Moves.Torment() };
	public override int Weight => 89;
	public override int ExpYield => 49;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}