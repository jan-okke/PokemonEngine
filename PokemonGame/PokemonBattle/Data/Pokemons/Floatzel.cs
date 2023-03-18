using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Floatzel : Pokemon
	{
		public override string Name => "Floatzel";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(85, 105, 55, 115, 85, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Icefang(), new Crunch(), new Tackle(), new Growl(), new Quickattack() },
			[4] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Tailwhip() },
			[11] = new List<Move>() { new Quickattack() },
			[15] = new List<Move>() { new Watergun() },
			[18] = new List<Move>() { new Bite() },
			[21] = new List<Move>() { new Swift() },
			[24] = new List<Move>() { new Aquajet() },
			[29] = new List<Move>() { new Doublehit() },
			[35] = new List<Move>() { new Whirlpool() },
			[41] = new List<Move>() { new Waterfall() },
			[46] = new List<Move>() { new Aquatail() },
			[51] = new List<Move>() { new Agility() },
			[57] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Blizzard(), new Brickbreak(), new Brine(), new Bulkup(), new Confide(), new Dig(), new Dive(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Liquidation(), new Lowkick(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Roar(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Torment(), new Waterfall(), new Waterpulse() };
		public override int Weight => 335;
		public override int ExpYield => 173;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}