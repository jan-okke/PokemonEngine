using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swinub : Pokemon
	{
		public override string Name => "Swinub";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Thickfat() };
		public override Stats BaseStats => new Stats(50, 50, 40, 30, 30, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Mudslap() },
			[5] = new List<Move>() { new Powdersnow() },
			[10] = new List<Move>() { new Flail() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Mist() },
			[25] = new List<Move>() { new Endure() },
			[30] = new List<Move>() { new Icywind() },
			[35] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Hail(), new Hiddenpower(), new Icebeam(), new Iciclespear(), new Icywind(), new Lightscreen(), new Mudshot(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Superpower(), new Swagger() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Bite(), new Bodyslam(), new Curse(), new Doubleedge(), new Fissure(), new Freezedry(), new Iciclecrash(), new Iciclespear(), new Mudshot(), new Mudshot(), new Takedown() };
		public override int Weight => 65;
		public override int ExpYield => 50;
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