using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Machamp : Pokemon
	{
		public override string Name => "Machamp";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Noguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(90, 130, 80, 55, 65, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wideguard(), new Lowkick(), new Leer(), new Focusenergy(), new Revenge() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Crosspoison(), new Darkestlariat(), new Dig(), new Doubleteam(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icepunch(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockblast(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thief(), new Throatchop(), new Thunderpunch(), new Workup() };
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
}