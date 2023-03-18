using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seel : Pokemon
	{
		public override string Name => "Seel";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(65, 45, 55, 45, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Headbutt() },
			[3] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Icywind() },
			[13] = new List<Move>() { new Encore() },
			[17] = new List<Move>() { new Iceshard() },
			[21] = new List<Move>() { new Rest() },
			[23] = new List<Move>() { new Aquaring() },
			[27] = new List<Move>() { new Aurorabeam() },
			[31] = new List<Move>() { new Aquajet() },
			[33] = new List<Move>() { new Brine() },
			[37] = new List<Move>() { new Takedown() },
			[41] = new List<Move>() { new Dive() },
			[43] = new List<Move>() { new Aquatail() },
			[47] = new List<Move>() { new Icebeam() },
			[51] = new List<Move>() { new Safeguard() },
			[53] = new List<Move>() { new Hail() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Drillrun(), new Echoedvoice(), new Endure(), new Facade(), new Fling(), new Frustration(), new Hail(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Signalbeam(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Waterfall(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Disable(), new Encore(), new Entrainment(), new Fakeout(), new Horndrill(), new Iciclespear(), new Lick(), new Perishsong(), new Slam(), new Spitup(), new Stockpile(), new Swallow() };
		public override int Weight => 900;
		public override int ExpYield => 65;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}