using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mareep : Pokemon
	{
		public override string Name => "Mareep";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Plus() };
		public override Stats BaseStats => new Stats(55, 40, 40, 35, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[4] = new List<Move>() { new Thunderwave() },
			[8] = new List<Move>() { new Thundershock() },
			[11] = new List<Move>() { new Cottonspore() },
			[15] = new List<Move>() { new Charge() },
			[18] = new List<Move>() { new Takedown() },
			[22] = new List<Move>() { new Electroball() },
			[25] = new List<Move>() { new Confuseray() },
			[29] = new List<Move>() { new Powergem() },
			[32] = new List<Move>() { new Discharge() },
			[36] = new List<Move>() { new Cottonguard() },
			[39] = new List<Move>() { new Chargebeam() },
			[43] = new List<Move>() { new Lightscreen() },
			[46] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Chargebeam(), new Confide(), new Doubleteam(), new Echoedvoice(), new Electroweb(), new Endure(), new Facade(), new Flash(), new Frustration(), new Healbell(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Magnetrise(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Agility(), new Bodyslam(), new Charge(), new Eerieimpulse(), new Electricterrain(), new Flatter(), new Sandattack(), new Screech(), new Takedown() };
		public override int Weight => 78;
		public override int ExpYield => 56;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}