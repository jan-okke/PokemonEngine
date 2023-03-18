using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hitmonlee : Pokemon
	{
		public override string Name => "Hitmonlee";
		public override List<Ability> AvailableAbilities => new() {new Limber(), new Reckless() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unburden() };
		public override Stats BaseStats => new Stats(50, 120, 53, 35, 110, 87);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Brickbreak() },
			[1] = new List<Move>() { new Brickbreak(), new Feint(), new Lowsweep(), new Tackle(), new Helpinghand(), new Fakeout(), new Focusenergy() },
			[4] = new List<Move>() { new Doublekick() },
			[8] = new List<Move>() { new Lowkick() },
			[12] = new List<Move>() { new Endure() },
			[16] = new List<Move>() { new Revenge() },
			[21] = new List<Move>() { new Wideguard() },
			[24] = new List<Move>() { new Blazekick() },
			[28] = new List<Move>() { new Mindreader() },
			[32] = new List<Move>() { new Megakick() },
			[36] = new List<Move>() { new Closecombat() },
			[40] = new List<Move>() { new Reversal() },
			[44] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Aurasphere(), new Blazekick(), new Bodyslam(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Helpinghand(), new Hiddenpower(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Thief(), new Throatchop(), new Uproar(), new Workup() };
		public override int Weight => 498;
		public override int ExpYield => 159;
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