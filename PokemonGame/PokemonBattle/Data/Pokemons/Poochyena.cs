using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Poochyena : Pokemon
{
	public override string Name => "Poochyena";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Quickfeet() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(35, 55, 35, 30, 30, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[4] = new List<Move>() { new Moves.Howl() },
		[7] = new List<Move>() { new Moves.Sandattack() },
		[10] = new List<Move>() { new Moves.Bite() },
		[13] = new List<Move>() { new Moves.Mudslap() },
		[16] = new List<Move>() { new Moves.Roar() },
		[19] = new List<Move>() { new Moves.Swagger() },
		[22] = new List<Move>() { new Moves.Assurance() },
		[25] = new List<Move>() { new Moves.Scaryface() },
		[28] = new List<Move>() { new Moves.Headbutt() },
		[31] = new List<Move>() { new Moves.Taunt() },
		[34] = new List<Move>() { new Moves.Crunch() },
		[37] = new List<Move>() { new Moves.Yawn() },
		[40] = new List<Move>() { new Moves.Takedown() },
		[43] = new List<Move>() { new Moves.Suckerpunch() },
		[46] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Covet(), new Moves.Firefang(), new Moves.Icefang(), new Moves.Leer(), new Moves.Playrough(), new Moves.Poisonfang(), new Moves.Suckerpunch(), new Moves.Thunderfang(), new Moves.Yawn() };
	public override int Weight => 136;
	public override int ExpYield => 56;
	public override int CatchRate => 255;
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