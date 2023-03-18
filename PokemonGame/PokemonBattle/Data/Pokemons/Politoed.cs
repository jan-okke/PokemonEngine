using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Politoed : Pokemon
	{
		public override string Name => "Politoed";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Damp() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Drizzle() };
		public override Stats BaseStats => new Stats(90, 75, 75, 90, 100, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bounce() },
			[1] = new List<Move>() { new Bounce(), new Swagger(), new Hypervoice(), new Perishsong(), new Bubblebeam(), new Raindance(), new Bodyslam(), new Earthpower(), new Hydropump(), new Bellydrum(), new Doubleedge(), new Watergun(), new Hypnosis(), new Pound(), new Mudshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Bulldoze(), new Dig(), new Dive(), new Doubleteam(), new Earthpower(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Liquidation(), new Megakick(), new Megapunch(), new Metronome(), new Muddywater(), new Mudshot(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Screech(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Thief(), new Uproar(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool() };
		public override int Weight => 339;
		public override int ExpYield => 250;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}