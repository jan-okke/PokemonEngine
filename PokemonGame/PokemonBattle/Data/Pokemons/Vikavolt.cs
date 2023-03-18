using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vikavolt : Pokemon
	{
		public override string Name => "Vikavolt";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(77, 70, 90, 145, 75, 43);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thunderbolt() },
			[1] = new List<Move>() { new Thunderbolt(), new Charge(), new Xscissor(), new Crunch(), new Dig(), new Irondefense(), new Discharge(), new Visegrip(), new Mudslap(), new Stringshot(), new Bugbite() },
			[15] = new List<Move>() { new Bite() },
			[23] = new List<Move>() { new Spark() },
			[29] = new List<Move>() { new Stickyweb() },
			[36] = new List<Move>() { new Bugbuzz() },
			[43] = new List<Move>() { new Guillotine() },
			[50] = new List<Move>() { new Fly() },
			[57] = new List<Move>() { new Agility() },
			[64] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Airslash(), new Attract(), new Bugbuzz(), new Crunch(), new Dig(), new Dualwingbeat(), new Eerieimpulse(), new Electroball(), new Electroweb(), new Endure(), new Energyball(), new Facade(), new Flashcannon(), new Fly(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Mudshot(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Xscissor() };
		public override int Weight => 450;
		public override int ExpYield => 250;
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