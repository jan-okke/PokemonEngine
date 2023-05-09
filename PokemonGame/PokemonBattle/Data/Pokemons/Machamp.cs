using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Machamp : Pokemon
{
	public override string Name => "Machamp";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Guts(), new Abilities.Noguard() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Steadfast() };
	public override Stats BaseStats => new Stats(90, 130, 80, 65, 85, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Wideguard(), new Moves.Lowkick(), new Moves.Leer(), new Moves.Focusenergy(), new Moves.Revenge() },
		[12] = new List<Move>() { new Moves.Lowsweep() },
		[16] = new List<Move>() { new Moves.Knockoff() },
		[20] = new List<Move>() { new Moves.Scaryface() },
		[24] = new List<Move>() { new Moves.Vitalthrow() },
		[31] = new List<Move>() { new Moves.Strength() },
		[36] = new List<Move>() { new Moves.Dualchop() },
		[42] = new List<Move>() { new Moves.Bulkup() },
		[48] = new List<Move>() { new Moves.Seismictoss() },
		[54] = new List<Move>() { new Moves.Dynamicpunch() },
		[60] = new List<Move>() { new Moves.Crosschop() },
		[66] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Crosspoison(), new Moves.Darkestlariat(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Workup() };
	public override int Weight => 1300;
	public override int ExpYield => 253;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}