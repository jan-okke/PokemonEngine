using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Grubbin : Pokemon
	{
		public override string Name => "Grubbin";
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(47, 62, 45, 55, 45, 46);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Visegrip(), new Mudslap() },
			[5] = new List<Move>() { new Stringshot() },
			[10] = new List<Move>() { new Bugbite() },
			[15] = new List<Move>() { new Bite() },
			[21] = new List<Move>() { new Spark() },
			[25] = new List<Move>() { new Stickyweb() },
			[30] = new List<Move>() { new Xscissor() },
			[35] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Dig() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Crunch(), new Dig(), new Electroweb(), new Endure(), new Facade(), new Hiddenpower(), new Lightscreen(), new Mudshot(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Round(), new Screech(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute(), new Thunderbolt(), new Thunderwave(), new Voltswitch(), new Wildcharge(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Discharge(), new Harden() };
		public override int Weight => 44;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}