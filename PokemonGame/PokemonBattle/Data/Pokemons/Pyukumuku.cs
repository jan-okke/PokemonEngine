using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pyukumuku : Pokemon
	{
		public override string Name => "Pyukumuku";
		public override List<Ability> AvailableAbilities => new() {new Innardsout() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(55, 60, 130, 5, 30, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Batonpass(), new Harden() },
			[5] = new List<Move>() { new Helpinghand() },
			[10] = new List<Move>() { new Taunt() },
			[15] = new List<Move>() { new Safeguard() },
			[20] = new List<Move>() { new Counter() },
			[25] = new List<Move>() { new Purify() },
			[30] = new List<Move>() { new Curse() },
			[35] = new List<Move>() { new Gastroacid() },
			[40] = new List<Move>() { new Painsplit() },
			[45] = new List<Move>() { new Recover() },
			[50] = new List<Move>() { new Soak() },
			[55] = new List<Move>() { new Toxic() },
			[60] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Endure(), new Hail(), new Helpinghand(), new Lightscreen(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Safeguard(), new Screech(), new Sleeptalk(), new Substitute(), new Taunt(), new Venomdrench() };
		public override List<Move> EggMoves => new List<Move>() { new Mirrorcoat(), new Spite(), new Swagger(), new Tickle() };
		public override int Weight => 12;
		public override int ExpYield => 144;
		public override int CatchRate => 60;
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