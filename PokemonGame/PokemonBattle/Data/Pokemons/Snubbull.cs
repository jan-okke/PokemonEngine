using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Snubbull : Pokemon
{
	public override string Name => "Snubbull";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Intimidate(), new Abilities.Runaway() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(60, 80, 50, 40, 40, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Icefang(), new Moves.Firefang(), new Moves.Thunderfang(), new Moves.Tackle(), new Moves.Scaryface(), new Moves.Tailwhip(), new Moves.Charm() },
		[7] = new List<Move>() { new Moves.Bite() },
		[13] = new List<Move>() { new Moves.Lick() },
		[19] = new List<Move>() { new Moves.Headbutt() },
		[25] = new List<Move>() { new Moves.Roar() },
		[31] = new List<Move>() { new Moves.Taunt() },
		[37] = new List<Move>() { new Moves.Playrough() },
		[43] = new List<Move>() { new Moves.Payback() },
		[49] = new List<Move>() { new Moves.Crunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icepunch(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Overheat(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Closecombat(), new Moves.Crunch(), new Moves.Doubleedge(), new Moves.Faketears(), new Moves.Firefang(), new Moves.Healbell(), new Moves.Icefang(), new Moves.Metronome(), new Moves.Mimic(), new Moves.Present(), new Moves.Snore(), new Moves.Thunderfang() };
	public override int Weight => 78;
	public override int ExpYield => 60;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}