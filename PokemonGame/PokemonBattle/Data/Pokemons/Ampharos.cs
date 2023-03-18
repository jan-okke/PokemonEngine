using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ampharos : Pokemon
	{
		public override string Name => "Ampharos";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Plus() };
		public override Stats BaseStats => new Stats(90, 75, 85, 115, 90, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thunderpunch() },
			[1] = new List<Move>() { new Thunderpunch(), new Zapcannon(), new Magneticflux(), new Dragonpulse(), new Firepunch(), new Tackle(), new Growl(), new Thunderwave(), new Thundershock() },
			[4] = new List<Move>() { new Thunderwave() },
			[8] = new List<Move>() { new Thundershock() },
			[11] = new List<Move>() { new Cottonspore() },
			[16] = new List<Move>() { new Charge() },
			[20] = new List<Move>() { new Takedown() },
			[25] = new List<Move>() { new Electroball() },
			[29] = new List<Move>() { new Confuseray() },
			[35] = new List<Move>() { new Powergem() },
			[40] = new List<Move>() { new Discharge() },
			[46] = new List<Move>() { new Cottonguard() },
			[51] = new List<Move>() { new Chargebeam() },
			[57] = new List<Move>() { new Lightscreen() },
			[62] = new List<Move>() { new Thunder() },
			[65] = new List<Move>() { new Dragonpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Chargebeam(), new Confide(), new Doubleteam(), new Dragonpulse(), new Echoedvoice(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Healbell(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Laserfocus(), new Lightscreen(), new Magnetrise(), new Outrage(), new Poweruppunch(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Return(), new Rockclimb(), new Rocksmash(), new Round(), new Safeguard(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 615;
		public override int ExpYield => 255;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}