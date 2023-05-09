using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Hitmonchan : Pokemon
{
	public override string Name => "Hitmonchan";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Ironfist() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(50, 105, 79, 35, 110, 76);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Drainpunch() },
		[1] = new List<Move>() { new Moves.Drainpunch(), new Moves.Feint(), new Moves.Vacuumwave(), new Moves.Bulletpunch(), new Moves.Tackle(), new Moves.Helpinghand(), new Moves.Fakeout(), new Moves.Focusenergy() },
		[4] = new List<Move>() { new Moves.Machpunch() },
		[8] = new List<Move>() { new Moves.Poweruppunch() },
		[12] = new List<Move>() { new Moves.Detect() },
		[16] = new List<Move>() { new Moves.Revenge() },
		[21] = new List<Move>() { new Moves.Quickguard() },
		[24] = new List<Move>() { new Moves.Thunderpunch(), new Moves.Icepunch(), new Moves.Firepunch() },
		[28] = new List<Move>() { new Moves.Agility() },
		[32] = new List<Move>() { new Moves.Megapunch() },
		[36] = new List<Move>() { new Moves.Closecombat() },
		[40] = new List<Move>() { new Moves.Counter() },
		[44] = new List<Move>() { new Moves.Focuspunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Focuspunch(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Workup() };
	public override int Weight => 502;
	public override int ExpYield => 159;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}