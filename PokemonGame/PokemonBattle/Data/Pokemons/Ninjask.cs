using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ninjask : Pokemon
	{
		public override string Name => "Ninjask";
		public override List<Ability> AvailableAbilities => new() {new Speedboost() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(61, 90, 45, 50, 50, 160);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Doubleteam(), new Screech(), new Furycutter() },
			[1] = new List<Move>() { new Doubleteam(), new Screech(), new Furycutter(), new Batonpass(), new Aerialace(), new Mudslap(), new Metalclaw(), new Dig(), new Sandattack(), new Scratch(), new Harden(), new Falseswipe() },
			[15] = new List<Move>() { new Agility() },
			[23] = new List<Move>() { new Absorb() },
			[29] = new List<Move>() { new Bugbite() },
			[36] = new List<Move>() { new Furyswipes() },
			[43] = new List<Move>() { new Mindreader() },
			[50] = new List<Move>() { new Slash() },
			[57] = new List<Move>() { new Swordsdance() },
			[64] = new List<Move>() { new Xscissor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Batonpass(), new Bugbuzz(), new Cut(), new Defog(), new Dig(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Protect(), new Rest(), new Roost(), new Round(), new Sandstorm(), new Screech(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Uproar(), new Uturn(), new Xscissor() };
		public override int Weight => 120;
		public override int ExpYield => 160;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}