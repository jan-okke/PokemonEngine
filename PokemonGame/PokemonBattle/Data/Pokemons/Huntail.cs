using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Huntail : Pokemon
	{
		public override string Name => "Huntail";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(55, 104, 105, 52, 94, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Whirlpool(), new Bite() },
			[5] = new List<Move>() { new Screech() },
			[9] = new List<Move>() { new Scaryface() },
			[11] = new List<Move>() { new Raindance() },
			[14] = new List<Move>() { new Waterpulse() },
			[16] = new List<Move>() { new Icefang() },
			[19] = new List<Move>() { new Brine() },
			[23] = new List<Move>() { new Suckerpunch() },
			[26] = new List<Move>() { new Dive() },
			[29] = new List<Move>() { new Batonpass() },
			[34] = new List<Move>() { new Crunch() },
			[39] = new List<Move>() { new Aquatail() },
			[45] = new List<Move>() { new Coil() },
			[50] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Bind(), new Blizzard(), new Bounce(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Frustration(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Infestation(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snatch(), new Snore(), new Substitute(), new Superfang(), new Surf(), new Swagger(), new Waterfall(), new Waterpulse() };
		public override int Weight => 270;
		public override int ExpYield => 170;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}