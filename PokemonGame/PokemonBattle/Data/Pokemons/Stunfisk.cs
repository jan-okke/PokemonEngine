using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stunfisk : Pokemon
	{
		public override string Name => "Stunfisk";
		public override List<Ability> AvailableAbilities => new() {new Static(), new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(109, 66, 84, 32, 81, 99);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Tackle(), new Watergun(), new Thundershock() },
			[5] = new List<Move>() { new Endure() },
			[10] = new List<Move>() { new Mudshot() },
			[15] = new List<Move>() { new Revenge() },
			[20] = new List<Move>() { new Charge() },
			[25] = new List<Move>() { new Suckerpunch() },
			[30] = new List<Move>() { new Electricterrain() },
			[35] = new List<Move>() { new Bounce() },
			[40] = new List<Move>() { new Muddywater() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Flail() },
			[55] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Bulldoze(), new Dig(), new Earthpower(), new Earthquake(), new Eerieimpulse(), new Electricterrain(), new Electroweb(), new Endure(), new Facade(), new Foulplay(), new Hiddenpower(), new Lashout(), new Muddywater(), new Mudshot(), new Payback(), new Protect(), new Raindance(), new Rest(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scald(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Surf(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Curse(), new Painsplit(), new Reflecttype(), new Spark(), new Spite(), new Yawn() };
		public override int Weight => 110;
		public override int ExpYield => 165;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}