using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Misdreavus : Pokemon
{
	public override string Name => "Misdreavus";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(60, 60, 60, 85, 85, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Confusion() },
		[5] = new List<Move>() { new Moves.Spite() },
		[10] = new List<Move>() { new Moves.Astonish() },
		[14] = new List<Move>() { new Moves.Confuseray() },
		[19] = new List<Move>() { new Moves.Meanlook() },
		[23] = new List<Move>() { new Moves.Hex() },
		[28] = new List<Move>() { new Moves.Psybeam() },
		[32] = new List<Move>() { new Moves.Painsplit() },
		[37] = new List<Move>() { new Moves.Payback() },
		[41] = new List<Move>() { new Moves.Shadowball() },
		[46] = new List<Move>() { new Moves.Perishsong() },
		[50] = new List<Move>() { new Moves.Grudge() },
		[55] = new List<Move>() { new Moves.Powergem() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Nastyplot(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Willowisp(), new Moves.Wonderroom() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Destinybond(), new Moves.Imprison(), new Moves.Memento(), new Moves.Screech(), new Moves.Shadowsneak(), new Moves.Spite(), new Moves.Suckerpunch(), new Moves.Wonderroom() };
	public override int Weight => 10;
	public override int ExpYield => 87;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}