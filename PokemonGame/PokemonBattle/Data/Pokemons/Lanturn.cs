using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lanturn : Pokemon
{
	public override string Name => "Lanturn";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Voltabsorb(), new Abilities.Illuminate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterabsorb() };
	public override Stats BaseStats => new Stats(125, 58, 58, 76, 76, 67);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup() },
		[1] = new List<Move>() { new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup(), new Moves.Eerieimpulse(), new Moves.Watergun(), new Moves.Supersonic(), new Moves.Electroball(), new Moves.Thunderwave() },
		[12] = new List<Move>() { new Moves.Bubblebeam() },
		[16] = new List<Move>() { new Moves.Confuseray() },
		[20] = new List<Move>() { new Moves.Spark() },
		[24] = new List<Move>() { new Moves.Charge() },
		[30] = new List<Move>() { new Moves.Discharge() },
		[36] = new List<Move>() { new Moves.Aquaring() },
		[42] = new List<Move>() { new Moves.Flail() },
		[48] = new List<Move>() { new Moves.Takedown() },
		[54] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Chargebeam(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Wildcharge() };
	public override int Weight => 225;
	public override int ExpYield => 161;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 2,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}