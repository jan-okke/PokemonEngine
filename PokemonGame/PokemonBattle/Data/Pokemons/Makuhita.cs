using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Makuhita : Pokemon
{
	public override string Name => "Makuhita";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Guts() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sheerforce() };
	public override Stats BaseStats => new Stats(72, 60, 30, 20, 30, 25);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Focusenergy() },
		[4] = new List<Move>() { new Moves.Sandattack() },
		[7] = new List<Move>() { new Moves.Armthrust() },
		[10] = new List<Move>() { new Moves.Fakeout() },
		[13] = new List<Move>() { new Moves.Forcepalm() },
		[16] = new List<Move>() { new Moves.Whirlwind() },
		[19] = new List<Move>() { new Moves.Knockoff() },
		[22] = new List<Move>() { new Moves.Vitalthrow() },
		[25] = new List<Move>() { new Moves.Bellydrum() },
		[28] = new List<Move>() { new Moves.Detect() },
		[31] = new List<Move>() { new Moves.Seismictoss() },
		[34] = new List<Move>() { new Moves.Focuspunch() },
		[37] = new List<Move>() { new Moves.Endure() },
		[40] = new List<Move>() { new Moves.Closecombat() },
		[43] = new List<Move>() { new Moves.Reversal() },
		[46] = new List<Move>() { new Moves.Heavyslam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Knockoff(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Smackdown(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bulletpunch(), new Moves.Counter(), new Moves.Crosschop(), new Moves.Detect(), new Moves.Dynamicpunch(), new Moves.Feint(), new Moves.Helpinghand(), new Moves.Revenge(), new Moves.Wideguard() };
	public override int Weight => 864;
	public override int ExpYield => 47;
	public override int CatchRate => 180;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}