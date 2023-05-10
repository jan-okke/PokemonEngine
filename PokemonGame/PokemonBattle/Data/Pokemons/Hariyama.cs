using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hariyama : Pokemon
{
	public override string Name => "Hariyama";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(144, 120, 60, 40, 60, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Brine(), new Moves.Tackle(), new Moves.Focusenergy(), new Moves.Sandattack(), new Moves.Armthrust() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[7] = new List<Move>() { new Moves.Armthrust() },
		[10] = new List<Move>() { new Moves.Fakeout() },
		[13] = new List<Move>() { new Moves.Forcepalm() },
		[16] = new List<Move>() { new Moves.Whirlwind() },
		[19] = new List<Move>() { new Moves.Knockoff() },
		[22] = new List<Move>() { new Moves.Vitalthrow() },
		[26] = new List<Move>() { new Moves.Bellydrum() },
		[30] = new List<Move>() { new Moves.Detect() },
		[34] = new List<Move>() { new Moves.Seismictoss() },
		[38] = new List<Move>() { new Moves.Focuspunch() },
		[42] = new List<Move>() { new Moves.Endure() },
		[46] = new List<Move>() { new Moves.Closecombat() },
		[50] = new List<Move>() { new Moves.Reversal() },
		[54] = new List<Move>() { new Moves.Heavyslam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Knockoff(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override int Weight => 2538;
	public override int ExpYield => 166;
	public override int CatchRate => 200;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}