using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kubfu : Pokemon
	{
		public override string Name => "Kubfu";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(60, 90, 60, 72, 53, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rocksmash(), new Leer() },
			[4] = new List<Move>() { new Endure() },
			[8] = new List<Move>() { new Focusenergy() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Closecombat(), new Coaching(), new Dig(), new Endure(), new Facade(), new Firepunch(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Substitute(), new Superpower(), new Thunderpunch(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 120;
		public override int ExpYield => 77;
		public override int CatchRate => 3;
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