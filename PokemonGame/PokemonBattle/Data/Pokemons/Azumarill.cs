using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Azumarill : Pokemon
	{
		public override string Name => "Azumarill";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hugepower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(100, 50, 80, 50, 60, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rollout(), new Defensecurl(), new Tackle(), new Watergun(), new Tailwhip(), new Helpinghand() },
			[6] = new List<Move>() { new Bubblebeam() },
			[9] = new List<Move>() { new Charm() },
			[12] = new List<Move>() { new Slam() },
			[15] = new List<Move>() { new Bounce() },
			[21] = new List<Move>() { new Aquatail() },
			[25] = new List<Move>() { new Playrough() },
			[30] = new List<Move>() { new Aquaring() },
			[35] = new List<Move>() { new Raindance() },
			[40] = new List<Move>() { new Hydropump() },
			[45] = new List<Move>() { new Doubleedge() },
			[50] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Charm(), new Dig(), new Dive(), new Doubleteam(), new Drainingkiss(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fling(), new Focusblast(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Liquidation(), new Megakick(), new Megapunch(), new Mistyexplosion(), new Mistyterrain(), new Muddywater(), new Mudshot(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swift(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override int Weight => 285;
		public override int ExpYield => 210;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}