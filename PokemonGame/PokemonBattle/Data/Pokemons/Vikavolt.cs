using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vikavolt : Pokemon
{
	public override string Name => "Vikavolt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(77, 70, 90, 145, 75, 43);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thunderbolt() },
		[1] = new List<Move>() { new Moves.Thunderbolt(), new Moves.Charge(), new Moves.Xscissor(), new Moves.Crunch(), new Moves.Dig(), new Moves.Irondefense(), new Moves.Discharge(), new Moves.Visegrip(), new Moves.Mudslap(), new Moves.Stringshot(), new Moves.Bugbite() },
		[15] = new List<Move>() { new Moves.Bite() },
		[23] = new List<Move>() { new Moves.Spark() },
		[29] = new List<Move>() { new Moves.Stickyweb() },
		[36] = new List<Move>() { new Moves.Bugbuzz() },
		[43] = new List<Move>() { new Moves.Guillotine() },
		[50] = new List<Move>() { new Moves.Fly() },
		[57] = new List<Move>() { new Moves.Agility() },
		[64] = new List<Move>() { new Moves.Zapcannon() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Bugbuzz(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dualwingbeat(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Xscissor() };
	public override int Weight => 450;
	public override int ExpYield => 250;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}