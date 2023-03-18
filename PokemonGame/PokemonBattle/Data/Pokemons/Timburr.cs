using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Timburr : Pokemon
	{
		public override string Name => "Timburr";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(75, 80, 55, 25, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Leer() },
			[4] = new List<Move>() { new Lowkick() },
			[8] = new List<Move>() { new Rockthrow() },
			[12] = new List<Move>() { new Focusenergy() },
			[16] = new List<Move>() { new Bulkup() },
			[20] = new List<Move>() { new Rockslide() },
			[24] = new List<Move>() { new Slam() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Dynamicpunch() },
			[36] = new List<Move>() { new Hammerarm() },
			[40] = new List<Move>() { new Stoneedge() },
			[44] = new List<Move>() { new Superpower() },
			[48] = new List<Move>() { new Focuspunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Coaching(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thunderpunch(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Defog(), new Detect(), new Machpunch(), new Poweruppunch(), new Wideguard() };
		public override int Weight => 125;
		public override int ExpYield => 61;
		public override int CatchRate => 180;
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