using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Manectric : Pokemon
{
	public override string Name => "Manectric";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static(), new Abilities.Lightningrod() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Minus() };
	public override Stats BaseStats => new Stats(70, 75, 60, 105, 60, 105);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Firefang(), new Moves.Tackle(), new Moves.Thunderwave(), new Moves.Leer(), new Moves.Howl() },
		[12] = new List<Move>() { new Moves.Quickattack() },
		[16] = new List<Move>() { new Moves.Shockwave() },
		[20] = new List<Move>() { new Moves.Bite() },
		[24] = new List<Move>() { new Moves.Thunderfang() },
		[30] = new List<Move>() { new Moves.Roar() },
		[36] = new List<Move>() { new Moves.Discharge() },
		[42] = new List<Move>() { new Moves.Charge() },
		[48] = new List<Move>() { new Moves.Wildcharge() },
		[54] = new List<Move>() { new Moves.Thunder() },
		[60] = new List<Move>() { new Moves.Electricterrain() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Overheat(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 402;
	public override int ExpYield => 166;
	public override int CatchRate => 45;
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