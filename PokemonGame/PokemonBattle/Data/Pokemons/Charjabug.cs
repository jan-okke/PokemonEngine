using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Charjabug : Pokemon
	{
		public override string Name => "Charjabug";
		public override List<Ability> AvailableAbilities => new() {new Battery() };
		public override Stats BaseStats => new Stats(57, 82, 95, 55, 75, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Charge() },
			[1] = new List<Move>() { new Charge(), new Visegrip(), new Mudslap(), new Stringshot(), new Bugbite() },
			[15] = new List<Move>() { new Bite() },
			[23] = new List<Move>() { new Spark() },
			[29] = new List<Move>() { new Stickyweb() },
			[36] = new List<Move>() { new Xscissor() },
			[43] = new List<Move>() { new Crunch() },
			[50] = new List<Move>() { new Dig() },
			[57] = new List<Move>() { new Irondefense() },
			[64] = new List<Move>() { new Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Crunch(), new Dig(), new Eerieimpulse(), new Electroball(), new Electroweb(), new Endure(), new Facade(), new Hiddenpower(), new Irondefense(), new Lightscreen(), new Mudshot(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Xscissor() };
		public override int Weight => 105;
		public override int ExpYield => 140;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}