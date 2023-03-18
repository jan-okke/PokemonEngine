using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Crabrawler : Pokemon
	{
		public override string Name => "Crabrawler";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Ironfist() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Angerpoint() };
		public override Stats BaseStats => new Stats(47, 82, 57, 42, 47, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bubble() },
			[5] = new List<Move>() { new Rocksmash() },
			[9] = new List<Move>() { new Leer() },
			[13] = new List<Move>() { new Pursuit() },
			[17] = new List<Move>() { new Bubblebeam() },
			[22] = new List<Move>() { new Poweruppunch() },
			[25] = new List<Move>() { new Dizzypunch() },
			[29] = new List<Move>() { new Payback() },
			[33] = new List<Move>() { new Reversal() },
			[37] = new List<Move>() { new Crabhammer() },
			[42] = new List<Move>() { new Irondefense() },
			[45] = new List<Move>() { new Dynamicpunch() },
			[49] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Confide(), new Doubleteam(), new Drainpunch(), new Dualchop(), new Earthquake(), new Endeavor(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Frostbreath(), new Frustration(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Ironhead(), new Payback(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockslide(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thief(), new Thunderpunch(), new Toxic(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Endeavor(), new Superpower(), new Wideguard() };
		public override int Weight => 70;
		public override int ExpYield => 68;
		public override int CatchRate => 225;
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