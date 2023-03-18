using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Milotic : Pokemon
	{
		public override string Name => "Milotic";
		public override List<Ability> AvailableAbilities => new() {new Marvelscale(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cutecharm() };
		public override Stats BaseStats => new Stats(95, 60, 79, 100, 125, 81);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Waterpulse() },
			[1] = new List<Move>() { new Waterpulse(), new Flail(), new Splash(), new Tackle(), new Wrap(), new Watergun() },
			[4] = new List<Move>() { new Disarmingvoice() },
			[8] = new List<Move>() { new Twister() },
			[12] = new List<Move>() { new Aquaring() },
			[16] = new List<Move>() { new Attract() },
			[20] = new List<Move>() { new Lifedew() },
			[24] = new List<Move>() { new Dragontail() },
			[28] = new List<Move>() { new Recover() },
			[32] = new List<Move>() { new Aquatail() },
			[36] = new List<Move>() { new Safeguard() },
			[40] = new List<Move>() { new Surf() },
			[44] = new List<Move>() { new Raindance() },
			[48] = new List<Move>() { new Coil() },
			[52] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Breakingswipe(), new Brine(), new Brutalswing(), new Bulldoze(), new Dive(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Flipturn(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Imprison(), new Ironhead(), new Irontail(), new Lightscreen(), new Muddywater(), new Mudshot(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Scaleshot(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Tripleaxel(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool() };
		public override int Weight => 1620;
		public override int ExpYield => 189;
		public override int CatchRate => 60;
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