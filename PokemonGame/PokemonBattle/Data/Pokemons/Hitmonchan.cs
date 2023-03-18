using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hitmonchan : Pokemon
	{
		public override string Name => "Hitmonchan";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Ironfist() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(50, 105, 79, 76, 35, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Drainpunch() },
			[1] = new List<Move>() { new Drainpunch(), new Feint(), new Vacuumwave(), new Bulletpunch(), new Tackle(), new Helpinghand(), new Fakeout(), new Focusenergy() },
			[4] = new List<Move>() { new Machpunch() },
			[8] = new List<Move>() { new Poweruppunch() },
			[12] = new List<Move>() { new Detect() },
			[16] = new List<Move>() { new Revenge() },
			[21] = new List<Move>() { new Quickguard() },
			[24] = new List<Move>() { new Thunderpunch(), new Icepunch(), new Firepunch() },
			[28] = new List<Move>() { new Agility() },
			[32] = new List<Move>() { new Megapunch() },
			[36] = new List<Move>() { new Closecombat() },
			[40] = new List<Move>() { new Counter() },
			[44] = new List<Move>() { new Focuspunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Aurasphere(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Doubleteam(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Throatchop(), new Thunderpunch(), new Uproar(), new Workup() };
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
}