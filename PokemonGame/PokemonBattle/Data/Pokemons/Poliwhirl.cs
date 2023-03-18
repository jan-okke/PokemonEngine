using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Poliwhirl : Pokemon
	{
		public override string Name => "Poliwhirl";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Damp() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(65, 65, 65, 50, 50, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Watergun(), new Hypnosis(), new Pound(), new Mudshot() },
			[18] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Raindance() },
			[32] = new List<Move>() { new Bodyslam() },
			[40] = new List<Move>() { new Earthpower() },
			[48] = new List<Move>() { new Hydropump() },
			[56] = new List<Move>() { new Bellydrum() },
			[66] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fling(), new Focuspunch(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Icywind(), new Megakick(), new Megapunch(), new Metronome(), new Muddywater(), new Mudshot(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 200;
		public override int ExpYield => 135;
		public override int CatchRate => 120;
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