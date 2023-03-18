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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hydration() };
		public override Stats BaseStats => new Stats(130, 85, 80, 85, 95, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Growl(), new Moves.Watergun() },
			[5] = new List<Move>() { new Moves.Sing() },
			[10] = new List<Move>() { new Moves.Mist() },
			[15] = new List<Move>() { new Moves.Lifedew() },
			[20] = new List<Move>() { new Moves.Iceshard() },
			[25] = new List<Move>() { new Moves.Confuseray() },
			[30] = new List<Move>() { new Moves.Waterpulse() },
			[35] = new List<Move>() { new Moves.Brine() },
			[40] = new List<Move>() { new Moves.Bodyslam() },
			[45] = new List<Move>() { new Moves.Icebeam() },
			[50] = new List<Move>() { new Moves.Raindance() },
			[55] = new List<Move>() { new Moves.Hydropump() },
			[60] = new List<Move>() { new Moves.Perishsong() },
			[65] = new List<Move>() { new Moves.Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Drillrun(), new Moves.Endure(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Megahorn(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Curse(), new Moves.Dragondance(), new Moves.Fissure(), new Moves.Freezedry(), new Moves.Futuresight(), new Moves.Horndrill(), new Moves.Tickle(), new Moves.Whirlpool() };
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