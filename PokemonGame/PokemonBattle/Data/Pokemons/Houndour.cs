using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Houndour : Pokemon
{
	public override string Name => "Houndour";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Earlybird(), new Abilities.Flashfire() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(45, 60, 30, 80, 50, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leer(), new Moves.Ember() },
		[4] = new List<Move>() { new Moves.Howl() },
		[8] = new List<Move>() { new Moves.Smog() },
		[13] = new List<Move>() { new Moves.Roar() },
		[16] = new List<Move>() { new Moves.Bite() },
		[20] = new List<Move>() { new Moves.Taunt() },
		[25] = new List<Move>() { new Moves.Beatup() },
		[28] = new List<Move>() { new Moves.Firefang() },
		[32] = new List<Move>() { new Moves.Payback() },
		[37] = new List<Move>() { new Moves.Flamecharge() },
		[40] = new List<Move>() { new Moves.Foulplay() },
		[44] = new List<Move>() { new Moves.Flamethrower() },
		[49] = new List<Move>() { new Moves.Crunch() },
		[52] = new List<Move>() { new Moves.Nastyplot() },
		[56] = new List<Move>() { new Moves.Inferno() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Beatup(), new Moves.Counter(), new Moves.Destinybond(), new Moves.Feint(), new Moves.Firefang(), new Moves.Firespin(), new Moves.Reversal(), new Moves.Spite(), new Moves.Suckerpunch(), new Moves.Thunderfang() };
	public override int Weight => 108;
	public override int ExpYield => 66;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}