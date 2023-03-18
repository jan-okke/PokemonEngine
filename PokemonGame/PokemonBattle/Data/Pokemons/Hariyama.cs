using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hariyama : Pokemon
	{
		public override string Name => "Hariyama";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(144, 120, 60, 40, 60, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Brine(), new Tackle(), new Focusenergy(), new Sandattack(), new Armthrust() },
			[4] = new List<Move>() { new Sandattack() },
			[7] = new List<Move>() { new Armthrust() },
			[10] = new List<Move>() { new Fakeout() },
			[13] = new List<Move>() { new Forcepalm() },
			[16] = new List<Move>() { new Whirlwind() },
			[19] = new List<Move>() { new Knockoff() },
			[22] = new List<Move>() { new Vitalthrow() },
			[26] = new List<Move>() { new Bellydrum() },
			[30] = new List<Move>() { new Detect() },
			[34] = new List<Move>() { new Seismictoss() },
			[38] = new List<Move>() { new Focuspunch() },
			[42] = new List<Move>() { new Endure() },
			[46] = new List<Move>() { new Closecombat() },
			[50] = new List<Move>() { new Reversal() },
			[54] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brine(), new Bulkup(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Ironhead(), new Knockoff(), new Lowkick(), new Lowsweep(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Sleeptalk(), new Smackdown(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Throatchop(), new Thunderpunch(), new Workup() };
		public override int Weight => 2538;
		public override int ExpYield => 166;
		public override int CatchRate => 200;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}