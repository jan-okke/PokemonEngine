using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ampharos : Pokemon
{
	public override string Name => "Ampharos";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Static() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Plus() };
	public override Stats BaseStats => new Stats(90, 75, 85, 115, 90, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Electric };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Thunderpunch() },
		[1] = new List<Move>() { new Moves.Thunderpunch(), new Moves.Zapcannon(), new Moves.Magneticflux(), new Moves.Dragonpulse(), new Moves.Firepunch(), new Moves.Tackle(), new Moves.Growl(), new Moves.Thunderwave(), new Moves.Thundershock() },
		[4] = new List<Move>() { new Moves.Thunderwave() },
		[8] = new List<Move>() { new Moves.Thundershock() },
		[11] = new List<Move>() { new Moves.Cottonspore() },
		[16] = new List<Move>() { new Moves.Charge() },
		[20] = new List<Move>() { new Moves.Takedown() },
		[25] = new List<Move>() { new Moves.Electroball() },
		[29] = new List<Move>() { new Moves.Confuseray() },
		[35] = new List<Move>() { new Moves.Powergem() },
		[40] = new List<Move>() { new Moves.Discharge() },
		[46] = new List<Move>() { new Moves.Cottonguard() },
		[51] = new List<Move>() { new Moves.Chargebeam() },
		[57] = new List<Move>() { new Moves.Lightscreen() },
		[62] = new List<Move>() { new Moves.Thunder() },
		[65] = new List<Move>() { new Moves.Dragonpulse() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Dragonpulse(), new Moves.Echoedvoice(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Magnetrise(), new Moves.Outrage(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge() };
	public override int Weight => 615;
	public override int ExpYield => 255;
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