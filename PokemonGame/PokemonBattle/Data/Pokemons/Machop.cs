using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Machop : Pokemon
	{
		public override string Name => "Machop";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Noguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(70, 80, 50, 35, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lowkick(), new Leer() },
			[4] = new List<Move>() { new Focusenergy() },
			[8] = new List<Move>() { new Revenge() },
			[12] = new List<Move>() { new Lowsweep() },
			[16] = new List<Move>() { new Knockoff() },
			[20] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Vitalthrow() },
			[29] = new List<Move>() { new Strength() },
			[32] = new List<Move>() { new Dualchop() },
			[36] = new List<Move>() { new Bulkup() },
			[40] = new List<Move>() { new Seismictoss() },
			[44] = new List<Move>() { new Dynamicpunch() },
			[48] = new List<Move>() { new Crosschop() },
			[52] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Dig(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thief(), new Thunderpunch(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Bulletpunch(), new Closecombat(), new Counter(), new Encore(), new Firepunch(), new Heavyslam(), new Icepunch(), new Knockoff(), new Powertrick(), new Quickguard(), new Submission(), new Thunderpunch(), new Tickle() };
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
}