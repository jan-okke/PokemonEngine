using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Buzzwole : Pokemon
	{
		public override string Name => "Buzzwole";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(107, 139, 139, 53, 53, 79);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poweruppunch(), new Harden() },
			[5] = new List<Move>() { new Taunt() },
			[10] = new List<Move>() { new Fellstinger() },
			[15] = new List<Move>() { new Vitalthrow() },
			[20] = new List<Move>() { new Bulkup() },
			[25] = new List<Move>() { new Endure() },
			[30] = new List<Move>() { new Reversal() },
			[35] = new List<Move>() { new Megapunch() },
			[40] = new List<Move>() { new Lunge() },
			[45] = new List<Move>() { new Focusenergy() },
			[50] = new List<Move>() { new Dynamicpunch() },
			[55] = new List<Move>() { new Counter() },
			[60] = new List<Move>() { new Hammerarm() },
			[65] = new List<Move>() { new Superpower() },
			[70] = new List<Move>() { new Focuspunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Darkestlariat(), new Drainpunch(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Focusenergy(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Highhorsepower(), new Icepunch(), new Ironhead(), new Leechlife(), new Lowsweep(), new Megapunch(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Taunt(), new Thunderpunch(), new Workup() };
		public override int Weight => 3336;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}