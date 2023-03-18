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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterveil() };
		public override Stats BaseStats => new Stats(55, 104, 105, 94, 75, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Whirlpool(), new Moves.Bite() },
			[5] = new List<Move>() { new Moves.Screech() },
			[9] = new List<Move>() { new Moves.Scaryface() },
			[11] = new List<Move>() { new Moves.Raindance() },
			[14] = new List<Move>() { new Moves.Waterpulse() },
			[16] = new List<Move>() { new Moves.Icefang() },
			[19] = new List<Move>() { new Moves.Brine() },
			[23] = new List<Move>() { new Moves.Suckerpunch() },
			[26] = new List<Move>() { new Moves.Dive() },
			[29] = new List<Move>() { new Moves.Batonpass() },
			[34] = new List<Move>() { new Moves.Crunch() },
			[39] = new List<Move>() { new Moves.Aquatail() },
			[45] = new List<Move>() { new Moves.Coil() },
			[50] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aquatail(), new Moves.Attract(), new Moves.Bind(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Confide(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Infestation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Superfang(), new Moves.Surf(), new Moves.Swagger(), new Moves.Waterfall(), new Moves.Waterpulse() };
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