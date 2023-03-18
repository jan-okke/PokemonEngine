using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tyrogue : Pokemon
	{
		public override string Name => "Tyrogue";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Steadfast() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(35, 35, 35, 35, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Helpinghand(), new Fakeout(), new Focusenergy() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocksmash(), new Round(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Bulletpunch(), new Counter(), new Feint(), new Helpinghand(), new Highjumpkick(), new Machpunch(), new Mindreader(), new Rapidspin(), new Vacuumwave() };
		public override int Weight => 210;
		public override int ExpYield => 42;
		public override int CatchRate => 75;
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