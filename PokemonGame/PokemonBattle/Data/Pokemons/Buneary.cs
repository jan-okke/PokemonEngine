using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Buneary : Pokemon
{
	public override string Name => "Buneary";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Klutz() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Limber() };
	public override Stats BaseStats => new Stats(55, 66, 44, 44, 56, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Splash(), new Moves.Pound() },
		[4] = new List<Move>() { new Moves.Defensecurl() },
		[8] = new List<Move>() { new Moves.Babydolleyes() },
		[12] = new List<Move>() { new Moves.Afteryou() },
		[16] = new List<Move>() { new Moves.Quickattack() },
		[20] = new List<Move>() { new Moves.Doublekick() },
		[24] = new List<Move>() { new Moves.Charm() },
		[28] = new List<Move>() { new Moves.Batonpass() },
		[32] = new List<Move>() { new Moves.Headbutt() },
		[36] = new List<Move>() { new Moves.Agility() },
		[40] = new List<Move>() { new Moves.Entrainment() },
		[44] = new List<Move>() { new Moves.Flatter() },
		[48] = new List<Move>() { new Moves.Bounce() },
		[52] = new List<Move>() { new Moves.Healingwish() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bounce(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cosmicpower(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Circlethrow(), new Moves.Copycat(), new Moves.Cosmicpower(), new Moves.Doublehit(), new Moves.Encore(), new Moves.Fakeout(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Flail(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Poweruppunch(), new Moves.Sweetkiss(), new Moves.Switcheroo(), new Moves.Teeterdance(), new Moves.Thunderpunch() };
	public override int Weight => 55;
	public override int ExpYield => 70;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}