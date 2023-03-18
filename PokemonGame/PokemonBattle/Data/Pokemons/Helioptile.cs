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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Dryskin(), new Abilities.Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Solarpower() };
		public override Stats BaseStats => new Stats(44, 38, 33, 61, 43, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Tailwhip() },
			[4] = new List<Move>() { new Moves.Pound() },
			[8] = new List<Move>() { new Moves.Thundershock() },
			[12] = new List<Move>() { new Moves.Quickattack() },
			[16] = new List<Move>() { new Moves.Charge() },
			[20] = new List<Move>() { new Moves.Bulldoze() },
			[24] = new List<Move>() { new Moves.Voltswitch() },
			[28] = new List<Move>() { new Moves.Paraboliccharge() },
			[32] = new List<Move>() { new Moves.Thunderwave() },
			[36] = new List<Move>() { new Moves.Thunderbolt() },
			[40] = new List<Move>() { new Moves.Electrify() },
			[44] = new List<Move>() { new Moves.Thunder() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Electricterrain(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Lowsweep(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Dragonrush(), new Moves.Dragontail(), new Moves.Glare() };
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