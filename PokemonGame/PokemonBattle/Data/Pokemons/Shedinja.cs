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
		public override List<Ability> AvailableAbilities => new() {new Wonderguard() };
		public override Stats BaseStats => new Stats(1, 90, 45, 40, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Shadowclaw(), new Grudge(), new Mudslap(), new Metalclaw(), new Dig(), new Scratch(), new Sandattack(), new Harden(), new Falseswipe() },
			[15] = new List<Move>() { new Confuseray() },
			[23] = new List<Move>() { new Absorb() },
			[29] = new List<Move>() { new Shadowsneak() },
			[36] = new List<Move>() { new Furyswipes() },
			[43] = new List<Move>() { new Mindreader() },
			[50] = new List<Move>() { new Shadowball() },
			[57] = new List<Move>() { new Spite() },
			[64] = new List<Move>() { new Phantomforce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Bugbuzz(), new Cut(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Gigadrain(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Phantomforce(), new Poltergeist(), new Protect(), new Rest(), new Round(), new Sandstorm(), new Shadowball(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Trick(), new Willowisp(), new Xscissor() };
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