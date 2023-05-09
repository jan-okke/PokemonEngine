using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Poliwag : Pokemon
{
	public override string Name => "Poliwag";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Damp() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
	public override Stats BaseStats => new Stats(40, 50, 40, 40, 40, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Watergun(), new Moves.Hypnosis() },
		[6] = new List<Move>() { new Moves.Pound() },
		[12] = new List<Move>() { new Moves.Mudshot() },
		[18] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Raindance() },
		[30] = new List<Move>() { new Moves.Bodyslam() },
		[36] = new List<Move>() { new Moves.Earthpower() },
		[42] = new List<Move>() { new Moves.Hydropump() },
		[48] = new List<Move>() { new Moves.Bellydrum() },
		[54] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thief(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bubblebeam(), new Moves.Encore(), new Moves.Endeavor(), new Moves.Haze(), new Moves.Mindreader(), new Moves.Mist(), new Moves.Mudshot(), new Moves.Splash() };
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