using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Aipom : Pokemon
{
	public override string Name => "Aipom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Pickup() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Skilllink() };
	public override Stats BaseStats => new Stats(55, 70, 55, 40, 55, 85);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Scratch(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[8] = new List<Move>() { new Moves.Astonish() },
		[11] = new List<Move>() { new Moves.Batonpass() },
		[15] = new List<Move>() { new Moves.Tickle() },
		[18] = new List<Move>() { new Moves.Furyswipes() },
		[22] = new List<Move>() { new Moves.Swift() },
		[25] = new List<Move>() { new Moves.Screech() },
		[29] = new List<Move>() { new Moves.Agility() },
		[32] = new List<Move>() { new Moves.Doublehit() },
		[36] = new List<Move>() { new Moves.Fling() },
		[39] = new List<Move>() { new Moves.Nastyplot() },
		[43] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Roleplay(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Beatup(), new Moves.Bounce(), new Moves.Counter(), new Moves.Covet(), new Moves.Fakeout(), new Moves.Quickguard(), new Moves.Revenge(), new Moves.Screech(), new Moves.Slam(), new Moves.Spite(), new Moves.Switcheroo() };
	public override int Weight => 115;
	public override int ExpYield => 72;
	public override int CatchRate => 45;
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