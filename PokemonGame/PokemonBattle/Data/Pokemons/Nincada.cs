using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nincada : Pokemon
	{
		public override string Name => "Nincada";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Runaway() };
		public override Stats BaseStats => new Stats(31, 45, 90, 30, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sandattack(), new Scratch() },
			[5] = new List<Move>() { new Harden() },
			[10] = new List<Move>() { new Falseswipe() },
			[15] = new List<Move>() { new Mudslap() },
			[21] = new List<Move>() { new Absorb() },
			[25] = new List<Move>() { new Metalclaw() },
			[30] = new List<Move>() { new Furyswipes() },
			[35] = new List<Move>() { new Mindreader() },
			[40] = new List<Move>() { new Dig() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Bugbuzz(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Gigadrain(), new Hiddenpower(), new Leechlife(), new Protect(), new Rest(), new Round(), new Sandstorm(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Finalgambit(), new Flail(), new Gust(), new Nightslash() };
		public override int Weight => 55;
		public override int ExpYield => 53;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}