using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Poliwhirl : Pokemon
{
	public override string Name => "Poliwhirl";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Damp() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
	public override Stats BaseStats => new Stats(65, 65, 65, 50, 50, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Hypnosis(), new Moves.Pound(), new Moves.Mudshot() },
		[18] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Raindance() },
		[32] = new List<Move>() { new Moves.Bodyslam() },
		[40] = new List<Move>() { new Moves.Earthpower() },
		[48] = new List<Move>() { new Moves.Hydropump() },
		[56] = new List<Move>() { new Moves.Bellydrum() },
		[66] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 200;
	public override int ExpYield => 135;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}