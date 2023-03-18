using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Machoke : Pokemon
	{
		public override string Name => "Machoke";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Noguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(80, 100, 70, 45, 50, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lowkick(), new Leer(), new Focusenergy(), new Revenge() },
			[12] = new List<Move>() { new Lowsweep() },
			[16] = new List<Move>() { new Knockoff() },
			[20] = new List<Move>() { new Scaryface() },
			[24] = new List<Move>() { new Vitalthrow() },
			[31] = new List<Move>() { new Strength() },
			[36] = new List<Move>() { new Dualchop() },
			[42] = new List<Move>() { new Bulkup() },
			[48] = new List<Move>() { new Seismictoss() },
			[54] = new List<Move>() { new Dynamicpunch() },
			[60] = new List<Move>() { new Crosschop() },
			[66] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Dig(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thief(), new Thunderpunch(), new Workup() };
		public override int Weight => 705;
		public override int ExpYield => 142;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}