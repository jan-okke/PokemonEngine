using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hitmontop : Pokemon
	{
		public override string Name => "Hitmontop";
		public override List<Ability> AvailableAbilities => new() {new Intimidate(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(50, 95, 95, 70, 35, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Triplekick() },
			[1] = new List<Move>() { new Triplekick(), new Feint(), new Rapidspin(), new Tackle(), new Helpinghand(), new Fakeout(), new Focusenergy() },
			[4] = new List<Move>() { new Quickattack() },
			[8] = new List<Move>() { new Gyroball() },
			[12] = new List<Move>() { new Detect() },
			[16] = new List<Move>() { new Revenge() },
			[21] = new List<Move>() { new Wideguard(), new Quickguard() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Agility() },
			[32] = new List<Move>() { new Dig() },
			[36] = new List<Move>() { new Closecombat() },
			[40] = new List<Move>() { new Counter() },
			[44] = new List<Move>() { new Endeavor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Dig(), new Doubleteam(), new Drillrun(), new Earthquake(), new Endure(), new Facade(), new Focusblast(), new Focusenergy(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocksmash(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Tripleaxel(), new Uproar(), new Workup() };
		public override int Weight => 480;
		public override int ExpYield => 159;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}