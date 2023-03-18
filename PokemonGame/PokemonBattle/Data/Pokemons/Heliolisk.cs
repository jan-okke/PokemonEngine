using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heliolisk : Pokemon
	{
		public override string Name => "Heliolisk";
		public override List<Ability> AvailableAbilities => new() {new Dryskin(), new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Solarpower() };
		public override Stats BaseStats => new Stats(62, 55, 52, 109, 94, 109);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Eerieimpulse(), new Discharge(), new Quickattack(), new Charge(), new Bulldoze(), new Voltswitch(), new Paraboliccharge(), new Thunderwave(), new Thunderbolt(), new Electrify(), new Thunder(), new Mudslap(), new Tailwhip(), new Pound(), new Thundershock() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Allyswitch(), new Attract(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Darkpulse(), new Dig(), new Dragonpulse(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Firepunch(), new Focusblast(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaleshot(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Surf(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uturn(), new Voltswitch(), new Weatherball(), new Wildcharge() };
		public override int Weight => 210;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}