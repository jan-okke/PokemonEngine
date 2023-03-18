using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Throh : Pokemon
	{
		public override string Name => "Throh";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moldbreaker() };
		public override Stats BaseStats => new Stats(120, 100, 85, 45, 30, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bind(), new Leer() },
			[5] = new List<Move>() { new Focusenergy() },
			[10] = new List<Move>() { new Circlethrow() },
			[15] = new List<Move>() { new Wideguard() },
			[20] = new List<Move>() { new Revenge() },
			[25] = new List<Move>() { new Bulkup() },
			[30] = new List<Move>() { new Stormthrow() },
			[35] = new List<Move>() { new Vitalthrow() },
			[40] = new List<Move>() { new Seismictoss() },
			[45] = new List<Move>() { new Endure() },
			[50] = new List<Move>() { new Reversal() },
			[55] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Coaching(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override int Weight => 555;
		public override int ExpYield => 163;
		public override int CatchRate => 45;
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