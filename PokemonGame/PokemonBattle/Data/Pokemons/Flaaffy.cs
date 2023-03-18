using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Flaaffy : Pokemon
	{
		public override string Name => "Flaaffy";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Plus() };
		public override Stats BaseStats => new Stats(70, 55, 55, 80, 60, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Thunderwave(), new Thundershock() },
			[4] = new List<Move>() { new Thunderwave() },
			[8] = new List<Move>() { new Thundershock() },
			[11] = new List<Move>() { new Cottonspore() },
			[16] = new List<Move>() { new Charge() },
			[20] = new List<Move>() { new Takedown() },
			[25] = new List<Move>() { new Electroball() },
			[29] = new List<Move>() { new Confuseray() },
			[34] = new List<Move>() { new Powergem() },
			[38] = new List<Move>() { new Discharge() },
			[43] = new List<Move>() { new Cottonguard() },
			[47] = new List<Move>() { new Chargebeam() },
			[52] = new List<Move>() { new Lightscreen() },
			[56] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Brickbreak(), new Chargebeam(), new Confide(), new Doubleteam(), new Echoedvoice(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Frustration(), new Healbell(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Magnetrise(), new Poweruppunch(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Return(), new Rocksmash(), new Round(), new Safeguard(), new Shockwave(), new Signalbeam(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 133;
		public override int ExpYield => 128;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}