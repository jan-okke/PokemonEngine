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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Marvelscale(), new Abilities.Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cutecharm() };
		public override Stats BaseStats => new Stats(95, 60, 79, 100, 125, 81);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Waterpulse() },
			[1] = new List<Move>() { new Moves.Waterpulse(), new Moves.Flail(), new Moves.Splash(), new Moves.Tackle(), new Moves.Wrap(), new Moves.Watergun() },
			[4] = new List<Move>() { new Moves.Disarmingvoice() },
			[8] = new List<Move>() { new Moves.Twister() },
			[12] = new List<Move>() { new Moves.Aquaring() },
			[16] = new List<Move>() { new Moves.Attract() },
			[20] = new List<Move>() { new Moves.Lifedew() },
			[24] = new List<Move>() { new Moves.Dragontail() },
			[28] = new List<Move>() { new Moves.Recover() },
			[32] = new List<Move>() { new Moves.Aquatail() },
			[36] = new List<Move>() { new Moves.Safeguard() },
			[40] = new List<Move>() { new Moves.Surf() },
			[44] = new List<Move>() { new Moves.Raindance() },
			[48] = new List<Move>() { new Moves.Coil() },
			[52] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flipturn(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Scaleshot(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tripleaxel(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool() };
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