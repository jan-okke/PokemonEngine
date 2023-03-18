using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pinsir : Pokemon
	{
		public override string Name => "Pinsir";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(65, 125, 100, 55, 70, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Visegrip(), new Harden() },
			[4] = new List<Move>() { new Focusenergy() },
			[8] = new List<Move>() { new Bind() },
			[12] = new List<Move>() { new Seismictoss() },
			[16] = new List<Move>() { new Bugbite() },
			[20] = new List<Move>() { new Stormthrow() },
			[24] = new List<Move>() { new Doublehit() },
			[28] = new List<Move>() { new Vitalthrow() },
			[32] = new List<Move>() { new Xscissor() },
			[36] = new List<Move>() { new Strength() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Submission() },
			[48] = new List<Move>() { new Guillotine() },
			[52] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Cut(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Protect(), new Raindance(), new Rest(), new Revenge(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swordsdance(), new Thief(), new Throatchop(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Closecombat(), new Feint(), new Flail(), new Furyattack(), new Quickattack(), new Superpower(), new Thrash() };
		public override int Weight => 550;
		public override int ExpYield => 175;
		public override int CatchRate => 45;
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