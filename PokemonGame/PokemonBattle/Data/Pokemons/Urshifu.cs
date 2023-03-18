using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Urshifu : Pokemon
	{
		public override string Name => "Urshifu";
		public override List<Ability> AvailableAbilities => new() {new Unseenfist() };
		public override Stats BaseStats => new Stats(100, 130, 100, 63, 60, 97);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Wickedblow() },
			[1] = new List<Move>() { new Wickedblow(), new Suckerpunch(), new Rocksmash(), new Leer(), new Endure(), new Focusenergy() },
			[12] = new List<Move>() { new Aerialace() },
			[16] = new List<Move>() { new Scaryface() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Brickbreak() },
			[28] = new List<Move>() { new Detect() },
			[32] = new List<Move>() { new Bulkup() },
			[36] = new List<Move>() { new Ironhead() },
			[40] = new List<Move>() { new Dynamicpunch() },
			[44] = new List<Move>() { new Counter() },
			[48] = new List<Move>() { new Closecombat() },
			[52] = new List<Move>() { new Focuspunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Attract(), new Aurasphere(), new Beatup(), new Bodypress(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Closecombat(), new Coaching(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Foulplay(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Ironhead(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snarl(), new Snore(), new Stoneedge(), new Substitute(), new Superpower(), new Swift(), new Taunt(), new Throatchop(), new Thunderpunch(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 1050;
		public override int ExpYield => 275;
		public override int CatchRate => 3;
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