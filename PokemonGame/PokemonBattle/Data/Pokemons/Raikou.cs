using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Raikou : Pokemon
{
	public override string Name => "Raikou";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(90, 85, 75, 115, 100, 115);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Extremespeed(), new Moves.Thundershock(), new Moves.Leer(), new Moves.Charge(), new Moves.Quickattack() },
		[6] = new List<Move>() { new Moves.Spark() },
		[12] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Calmmind() },
		[24] = new List<Move>() { new Moves.Roar() },
		[30] = new List<Move>() { new Moves.Thunderfang() },
		[36] = new List<Move>() { new Moves.Howl() },
		[42] = new List<Move>() { new Moves.Crunch() },
		[48] = new List<Move>() { new Moves.Extrasensory() },
		[54] = new List<Move>() { new Moves.Discharge() },
		[60] = new List<Move>() { new Moves.Reflect() },
		[66] = new List<Move>() { new Moves.Raindance() },
		[72] = new List<Move>() { new Moves.Thunder() },
		[78] = new List<Move>() { new Moves.Zapcannon() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Aurasphere(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Weatherball(), new Moves.Wildcharge() };
	public override int Weight => 1780;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}