using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Luxio : Pokemon
{
	public override string Name => "Luxio";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rivalry(), new Abilities.Intimidate() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Guts() };
	public override Stats BaseStats => new Stats(60, 85, 49, 60, 49, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer(), new Moves.Thundershock(), new Moves.Charge() },
		[12] = new List<Move>() { new Moves.Bite() },
		[18] = new List<Move>() { new Moves.Spark() },
		[24] = new List<Move>() { new Moves.Roar() },
		[31] = new List<Move>() { new Moves.Voltswitch() },
		[36] = new List<Move>() { new Moves.Scaryface() },
		[42] = new List<Move>() { new Moves.Thunderwave() },
		[48] = new List<Move>() { new Moves.Crunch() },
		[54] = new List<Move>() { new Moves.Discharge() },
		[60] = new List<Move>() { new Moves.Swagger() },
		[68] = new List<Move>() { new Moves.Wildcharge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Chargebeam(), new Moves.Crunch(), new Moves.Doubleteam(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firefang(), new Moves.Flash(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icefang(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 305;
	public override int ExpYield => 127;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}