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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Battery() };
		public override Stats BaseStats => new Stats(57, 82, 95, 55, 75, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Charge() },
			[1] = new List<Move>() { new Moves.Charge(), new Moves.Visegrip(), new Moves.Mudslap(), new Moves.Stringshot(), new Moves.Bugbite() },
			[15] = new List<Move>() { new Moves.Bite() },
			[23] = new List<Move>() { new Moves.Spark() },
			[29] = new List<Move>() { new Moves.Stickyweb() },
			[36] = new List<Move>() { new Moves.Xscissor() },
			[43] = new List<Move>() { new Moves.Crunch() },
			[50] = new List<Move>() { new Moves.Dig() },
			[57] = new List<Move>() { new Moves.Irondefense() },
			[64] = new List<Move>() { new Moves.Discharge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Crunch(), new Moves.Dig(), new Moves.Eerieimpulse(), new Moves.Electroball(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Mudshot(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Round(), new Moves.Screech(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Voltswitch(), new Moves.Wildcharge(), new Moves.Xscissor() };
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