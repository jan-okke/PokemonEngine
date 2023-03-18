using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Azurill : Pokemon
	{
		public override string Name => "Azurill";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hugepower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sapsipper() };
		public override Stats BaseStats => new Stats(50, 20, 40, 20, 20, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Watergun(), new Tailwhip() },
			[3] = new List<Move>() { new Helpinghand() },
			[6] = new List<Move>() { new Bubblebeam() },
			[9] = new List<Move>() { new Charm() },
			[12] = new List<Move>() { new Slam() },
			[15] = new List<Move>() { new Bounce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Brutalswing(), new Charm(), new Doubleteam(), new Drainingkiss(), new Encore(), new Endure(), new Facade(), new Faketears(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Lightscreen(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aquajet(), new Bellydrum(), new Bodyslam(), new Copycat(), new Encore(), new Faketears(), new Muddywater(), new Perishsong(), new Present(), new Sing(), new Slam(), new Soak(), new Supersonic(), new Tickle() };
		public override int Weight => 20;
		public override int ExpYield => 38;
		public override int CatchRate => 150;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}