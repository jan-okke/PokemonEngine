using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Crabominable : Pokemon
	{
		public override string Name => "Crabominable";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Ironfist() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Angerpoint() };
		public override Stats BaseStats => new Stats(97, 132, 77, 62, 67, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Icepunch() },
			[1] = new List<Move>() { new Moves.Icepunch(), new Moves.Bubble(), new Moves.Rocksmash(), new Moves.Leer(), new Moves.Pursuit() },
			[5] = new List<Move>() { new Moves.Rocksmash() },
			[9] = new List<Move>() { new Moves.Leer() },
			[13] = new List<Move>() { new Moves.Pursuit() },
			[17] = new List<Move>() { new Moves.Bubblebeam() },
			[22] = new List<Move>() { new Moves.Poweruppunch() },
			[25] = new List<Move>() { new Moves.Dizzypunch() },
			[29] = new List<Move>() { new Moves.Avalanche() },
			[33] = new List<Move>() { new Moves.Reversal() },
			[37] = new List<Move>() { new Moves.Icehammer() },
			[42] = new List<Move>() { new Moves.Irondefense() },
			[45] = new List<Move>() { new Moves.Dynamicpunch() },
			[49] = new List<Move>() { new Moves.Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Block(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dualchop(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frostbreath(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Payback(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 1800;
		public override int ExpYield => 167;
		public override int CatchRate => 60;
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