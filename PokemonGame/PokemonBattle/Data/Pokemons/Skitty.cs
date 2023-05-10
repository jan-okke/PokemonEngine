using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Skitty : Pokemon
{
	public override string Name => "Skitty";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Normalize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Wonderskin() };
	public override Stats BaseStats => new Stats(50, 45, 45, 35, 35, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Fakeout(), new Moves.Growl(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Tackle() },
		[7] = new List<Move>() { new Moves.Sing() },
		[10] = new List<Move>() { new Moves.Attract() },
		[13] = new List<Move>() { new Moves.Disarmingvoice() },
		[16] = new List<Move>() { new Moves.Furyswipes() },
		[19] = new List<Move>() { new Moves.Copycat() },
		[22] = new List<Move>() { new Moves.Payback() },
		[25] = new List<Move>() { new Moves.Charm() },
		[31] = new List<Move>() { new Moves.Facade() },
		[34] = new List<Move>() { new Moves.Covet() },
		[37] = new List<Move>() { new Moves.Healbell() },
		[40] = new List<Move>() { new Moves.Doubleedge() },
		[43] = new List<Move>() { new Moves.Babydolleyes() },
		[46] = new List<Move>() { new Moves.Playrough() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lastresort(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Batonpass(), new Moves.Cosmicpower(), new Moves.Fakeout(), new Moves.Faketears(), new Moves.Helpinghand(), new Moves.Lastresort(), new Moves.Simplebeam(), new Moves.Suckerpunch(), new Moves.Tickle(), new Moves.Uproar(), new Moves.Wish(), new Moves.Zenheadbutt() };
	public override int Weight => 110;
	public override int ExpYield => 52;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}