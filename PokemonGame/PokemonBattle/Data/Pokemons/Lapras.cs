using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lapras : Pokemon
	{
		public override string Name => "Lapras";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hydration() };
		public override Stats BaseStats => new Stats(130, 85, 80, 60, 85, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Watergun() },
			[5] = new List<Move>() { new Sing() },
			[10] = new List<Move>() { new Mist() },
			[15] = new List<Move>() { new Lifedew() },
			[20] = new List<Move>() { new Iceshard() },
			[25] = new List<Move>() { new Confuseray() },
			[30] = new List<Move>() { new Waterpulse() },
			[35] = new List<Move>() { new Brine() },
			[40] = new List<Move>() { new Bodyslam() },
			[45] = new List<Move>() { new Icebeam() },
			[50] = new List<Move>() { new Raindance() },
			[55] = new List<Move>() { new Hydropump() },
			[60] = new List<Move>() { new Perishsong() },
			[65] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Brine(), new Bulldoze(), new Charm(), new Dive(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Dreameater(), new Drillrun(), new Endure(), new Facade(), new Futuresight(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Ironhead(), new Irontail(), new Liquidation(), new Megahorn(), new Outrage(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Round(), new Safeguard(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Curse(), new Dragondance(), new Fissure(), new Freezedry(), new Futuresight(), new Horndrill(), new Tickle(), new Whirlpool() };
		public override int Weight => 2200;
		public override int ExpYield => 187;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}