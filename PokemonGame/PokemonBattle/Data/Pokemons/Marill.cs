using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marill : Pokemon
	{
		public override string Name => "Marill";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hugepower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(70, 20, 50, 40, 20, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rollout(), new Defensecurl(), new Tackle(), new Watergun(), new Tailwhip(), new Helpinghand() },
			[6] = new List<Move>() { new Bubblebeam() },
			[9] = new List<Move>() { new Charm() },
			[12] = new List<Move>() { new Slam() },
			[15] = new List<Move>() { new Bounce() },
			[19] = new List<Move>() { new Aquatail() },
			[21] = new List<Move>() { new Playrough() },
			[24] = new List<Move>() { new Aquaring() },
			[27] = new List<Move>() { new Raindance() },
			[30] = new List<Move>() { new Hydropump() },
			[33] = new List<Move>() { new Doubleedge() },
			[36] = new List<Move>() { new Superpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Brutalswing(), new Charm(), new Dig(), new Dive(), new Doubleteam(), new Drainingkiss(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fling(), new Focuspunch(), new Futuresight(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Mistyexplosion(), new Mistyterrain(), new Muddywater(), new Mudshot(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Steelroller(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swift(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Aquajet(), new Bellydrum(), new Bodyslam(), new Copycat(), new Futuresight(), new Muddywater(), new Perishsong(), new Present(), new Sing(), new Soak(), new Superpower(), new Supersonic(), new Tickle() };
		public override int Weight => 85;
		public override int ExpYield => 88;
		public override int CatchRate => 190;
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