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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Runaway() };
		public override Stats BaseStats => new Stats(31, 45, 90, 30, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sandattack(), new Moves.Scratch() },
			[5] = new List<Move>() { new Moves.Harden() },
			[10] = new List<Move>() { new Moves.Falseswipe() },
			[15] = new List<Move>() { new Moves.Mudslap() },
			[21] = new List<Move>() { new Moves.Absorb() },
			[25] = new List<Move>() { new Moves.Metalclaw() },
			[30] = new List<Move>() { new Moves.Furyswipes() },
			[35] = new List<Move>() { new Moves.Mindreader() },
			[40] = new List<Move>() { new Moves.Dig() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Bugbuzz(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Bugbite(), new Moves.Finalgambit(), new Moves.Flail(), new Moves.Gust(), new Moves.Nightslash() };
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