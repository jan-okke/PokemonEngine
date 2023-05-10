using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mareep : Pokemon
{
	public override string Name => "Mareep";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Plus() };
	public override Stats BaseStats => new Stats(55, 40, 40, 65, 45, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
		[4] = new List<Move>() { new Moves.Thunderwave() },
		[8] = new List<Move>() { new Moves.Thundershock() },
		[11] = new List<Move>() { new Moves.Cottonspore() },
		[15] = new List<Move>() { new Moves.Charge() },
		[18] = new List<Move>() { new Moves.Takedown() },
		[22] = new List<Move>() { new Moves.Electroball() },
		[25] = new List<Move>() { new Moves.Confuseray() },
		[29] = new List<Move>() { new Moves.Powergem() },
		[32] = new List<Move>() { new Moves.Discharge() },
		[36] = new List<Move>() { new Moves.Cottonguard() },
		[39] = new List<Move>() { new Moves.Chargebeam() },
		[43] = new List<Move>() { new Moves.Lightscreen() },
		[46] = new List<Move>() { new Moves.Thunder() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Wildcharge() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Agility(), new Moves.Bodyslam(), new Moves.Charge(), new Moves.Eerieimpulse(), new Moves.Electricterrain(), new Moves.Flatter(), new Moves.Sandattack(), new Moves.Screech(), new Moves.Takedown() };
	public override int Weight => 78;
	public override int ExpYield => 56;
	public override int CatchRate => 235;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}