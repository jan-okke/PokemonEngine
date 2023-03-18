using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Poliwrath : Pokemon
	{
		public override string Name => "Poliwrath";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Damp() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(90, 95, 95, 70, 70, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Submission() },
			[1] = new List<Move>() { new Submission(), new Circlethrow(), new Mindreader(), new Dynamicpunch(), new Bubblebeam(), new Raindance(), new Bodyslam(), new Earthpower(), new Hydropump(), new Bellydrum(), new Doubleedge(), new Watergun(), new Hypnosis(), new Pound(), new Mudshot() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Darkestlariat(), new Dig(), new Dive(), new Doubleteam(), new Drainpunch(), new Earthpower(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Liquidation(), new Lowsweep(), new Megakick(), new Megapunch(), new Metronome(), new Muddywater(), new Mudshot(), new Payback(), new Poisonjab(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Reversal(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Thief(), new Throatchop(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override int Weight => 540;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}