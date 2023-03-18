using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dewgong : Pokemon
	{
		public override string Name => "Dewgong";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(90, 70, 80, 70, 70, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Sheercold() },
			[1] = new List<Move>() { new Sheercold(), new Headbutt(), new Growl(), new Bubblebeam(), new Icywind() },
			[3] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Bubblebeam() },
			[11] = new List<Move>() { new Icywind() },
			[13] = new List<Move>() { new Encore() },
			[17] = new List<Move>() { new Iceshard() },
			[21] = new List<Move>() { new Rest() },
			[23] = new List<Move>() { new Aquaring() },
			[27] = new List<Move>() { new Aurorabeam() },
			[31] = new List<Move>() { new Aquajet() },
			[33] = new List<Move>() { new Brine() },
			[39] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Dive() },
			[49] = new List<Move>() { new Aquatail() },
			[55] = new List<Move>() { new Icebeam() },
			[61] = new List<Move>() { new Safeguard() },
			[65] = new List<Move>() { new Hail() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aquatail(), new Attract(), new Avalanche(), new Blizzard(), new Brine(), new Confide(), new Dive(), new Doubleteam(), new Drillrun(), new Echoedvoice(), new Endure(), new Facade(), new Fling(), new Frostbreath(), new Frustration(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Signalbeam(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Waterfall(), new Waterpulse() };
		public override int Weight => 1200;
		public override int ExpYield => 166;
		public override int CatchRate => 75;
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