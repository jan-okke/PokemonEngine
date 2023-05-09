using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Machop : Pokemon
{
	public override string Name => "Machop";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Noguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(70, 80, 50, 35, 35, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Lowkick(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Focusenergy() },
		[8] = new List<Move>() { new Moves.Revenge() },
		[12] = new List<Move>() { new Moves.Lowsweep() },
		[16] = new List<Move>() { new Moves.Knockoff() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[24] = new List<Move>() { new Moves.Vitalthrow() },
		[29] = new List<Move>() { new Moves.Strength() },
		[32] = new List<Move>() { new Moves.Dualchop() },
		[36] = new List<Move>() { new Moves.Bulkup() },
		[40] = new List<Move>() { new Moves.Seismictoss() },
		[44] = new List<Move>() { new Moves.Dynamicpunch() },
		[48] = new List<Move>() { new Moves.Crosschop() },
		[52] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bulletpunch(), new Moves.Closecombat(), new Moves.Counter(), new Moves.Encore(), new Moves.Firepunch(), new Moves.Heavyslam(), new Moves.Icepunch(), new Moves.Knockoff(), new Moves.Powertrick(), new Moves.Quickguard(), new Moves.Submission(), new Moves.Thunderpunch(), new Moves.Tickle() };
	public override int Weight => 195;
	public override int ExpYield => 61;
	public override int CatchRate => 180;
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