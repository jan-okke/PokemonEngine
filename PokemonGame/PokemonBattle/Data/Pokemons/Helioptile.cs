using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Helioptile : Pokemon
	{
		public override string Name => "Helioptile";
		public override List<Ability> AvailableAbilities => new() {new Dryskin(), new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Solarpower() };
		public override Stats BaseStats => new Stats(44, 38, 33, 70, 61, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Tailwhip() },
			[4] = new List<Move>() { new Pound() },
			[8] = new List<Move>() { new Thundershock() },
			[12] = new List<Move>() { new Quickattack() },
			[16] = new List<Move>() { new Charge() },
			[20] = new List<Move>() { new Bulldoze() },
			[24] = new List<Move>() { new Voltswitch() },
			[28] = new List<Move>() { new Paraboliccharge() },
			[32] = new List<Move>() { new Thunderwave() },
			[36] = new List<Move>() { new Thunderbolt() },
			[40] = new List<Move>() { new Electrify() },
			[44] = new List<Move>() { new Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Bulldoze(), new Darkpulse(), new Dig(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Grassknot(), new Hiddenpower(), new Irontail(), new Lightscreen(), new Lowsweep(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaleshot(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uturn(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Dragonrush(), new Dragontail(), new Glare() };
		public override int Weight => 60;
		public override int ExpYield => 58;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}