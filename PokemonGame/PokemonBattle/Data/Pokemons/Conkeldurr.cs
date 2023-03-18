using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Conkeldurr : Pokemon
	{
		public override string Name => "Conkeldurr";
		public override List<Ability> AvailableAbilities => new() {new Guts(), new Sheerforce() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(105, 140, 95, 45, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Leer(), new Lowkick(), new Rockthrow() },
			[12] = new List<Move>() { new Focusenergy() },
			[16] = new List<Move>() { new Bulkup() },
			[20] = new List<Move>() { new Rockslide() },
			[24] = new List<Move>() { new Slam() },
			[30] = new List<Move>() { new Scaryface() },
			[36] = new List<Move>() { new Dynamicpunch() },
			[42] = new List<Move>() { new Hammerarm() },
			[48] = new List<Move>() { new Stoneedge() },
			[54] = new List<Move>() { new Superpower() },
			[60] = new List<Move>() { new Focuspunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Dig(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icepunch(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Taunt(), new Thunderpunch(), new Workup() };
		public override int Weight => 870;
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