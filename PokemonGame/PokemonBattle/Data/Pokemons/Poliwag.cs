using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Poliwag : Pokemon
	{
		public override string Name => "Poliwag";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Damp() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(40, 50, 40, 90, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Hypnosis() },
			[6] = new List<Move>() { new Pound() },
			[12] = new List<Move>() { new Mudshot() },
			[18] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Raindance() },
			[30] = new List<Move>() { new Bodyslam() },
			[36] = new List<Move>() { new Earthpower() },
			[42] = new List<Move>() { new Hydropump() },
			[48] = new List<Move>() { new Bellydrum() },
			[54] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Encore(), new Endure(), new Facade(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Muddywater(), new Mudshot(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Bubblebeam(), new Encore(), new Endeavor(), new Haze(), new Mindreader(), new Mist(), new Mudshot(), new Splash() };
		public override int Weight => 124;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}