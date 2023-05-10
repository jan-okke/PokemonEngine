using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rotom : Pokemon
{
	public override string Name => "Rotom";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(50, 50, 77, 95, 77, 91);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Ghost };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Astonish(), new Moves.Doubleteam() },
		[5] = new List<Move>() { new Moves.Thundershock() },
		[10] = new List<Move>() { new Moves.Confuseray() },
		[15] = new List<Move>() { new Moves.Charge() },
		[20] = new List<Move>() { new Moves.Electroball() },
		[25] = new List<Move>() { new Moves.Thunderwave() },
		[30] = new List<Move>() { new Moves.Shockwave() },
		[35] = new List<Move>() { new Moves.Hex() },
		[40] = new List<Move>() { new Moves.Substitute() },
		[45] = new List<Move>() { new Moves.Trick() },
		[50] = new List<Move>() { new Moves.Discharge() },
		[55] = new List<Move>() { new Moves.Uproar() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Chargebeam(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Foulplay(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Lightscreen(), new Moves.Nastyplot(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uproar(), new Moves.Voltswitch(), new Moves.Willowisp() };
	public override int Weight => 3;
	public override int ExpYield => 154;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}