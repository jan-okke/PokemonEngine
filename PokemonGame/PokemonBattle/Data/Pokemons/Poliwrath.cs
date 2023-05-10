using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Poliwrath : Pokemon
{
	public override string Name => "Poliwrath";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Damp() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
	public override Stats BaseStats => new Stats(90, 95, 95, 70, 90, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Submission() },
		[1] = new List<Move>() { new Moves.Submission(), new Moves.Circlethrow(), new Moves.Mindreader(), new Moves.Dynamicpunch(), new Moves.Bubblebeam(), new Moves.Raindance(), new Moves.Bodyslam(), new Moves.Earthpower(), new Moves.Hydropump(), new Moves.Bellydrum(), new Moves.Doubleedge(), new Moves.Watergun(), new Moves.Hypnosis(), new Moves.Pound(), new Moves.Mudshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Darkestlariat(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
	public override int Weight => 540;
	public override int ExpYield => 255;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 3,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}