using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Makuhita : Pokemon
	{
		public override string Name => "Makuhita";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(72, 60, 30, 20, 30, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Focusenergy() },
			[4] = new List<Move>() { new Sandattack() },
			[7] = new List<Move>() { new Armthrust() },
			[10] = new List<Move>() { new Fakeout() },
			[13] = new List<Move>() { new Forcepalm() },
			[16] = new List<Move>() { new Whirlwind() },
			[19] = new List<Move>() { new Knockoff() },
			[22] = new List<Move>() { new Vitalthrow() },
			[25] = new List<Move>() { new Bellydrum() },
			[28] = new List<Move>() { new Detect() },
			[31] = new List<Move>() { new Seismictoss() },
			[34] = new List<Move>() { new Focuspunch() },
			[37] = new List<Move>() { new Endure() },
			[40] = new List<Move>() { new Closecombat() },
			[43] = new List<Move>() { new Reversal() },
			[46] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Knockoff(), new Lowkick(), new Lowsweep(), new Poisonjab(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Sleeptalk(), new Smackdown(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swagger(), new Thunderpunch(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Bulletpunch(), new Counter(), new Crosschop(), new Detect(), new Dynamicpunch(), new Feint(), new Helpinghand(), new Revenge(), new Wideguard() };
		public override int Weight => 864;
		public override int ExpYield => 47;
		public override int CatchRate => 180;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}