using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shedinja : Pokemon
	{
		public override string Name => "Shedinja";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Wonderguard() };
		public override Stats BaseStats => new Stats(1, 90, 45, 30, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Shadowclaw(), new Moves.Grudge(), new Moves.Mudslap(), new Moves.Metalclaw(), new Moves.Dig(), new Moves.Scratch(), new Moves.Sandattack(), new Moves.Harden(), new Moves.Falseswipe() },
			[15] = new List<Move>() { new Moves.Confuseray() },
			[23] = new List<Move>() { new Moves.Absorb() },
			[29] = new List<Move>() { new Moves.Shadowsneak() },
			[36] = new List<Move>() { new Moves.Furyswipes() },
			[43] = new List<Move>() { new Moves.Mindreader() },
			[50] = new List<Move>() { new Moves.Shadowball() },
			[57] = new List<Move>() { new Moves.Spite() },
			[64] = new List<Move>() { new Moves.Phantomforce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Bugbuzz(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Trick(), new Moves.Willowisp(), new Moves.Xscissor() };
		public override int Weight => 12;
		public override int ExpYield => 83;
		public override int CatchRate => 45;
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