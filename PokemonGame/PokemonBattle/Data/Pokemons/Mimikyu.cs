using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mimikyu : Pokemon
	{
		public override string Name => "Mimikyu";
		public override List<Ability> AvailableAbilities => new() {new Disguise() };
		public override Stats BaseStats => new Stats(55, 90, 80, 50, 105, 96);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Woodhammer(), new Splash(), new Astonish(), new Scratch(), new Copycat() },
			[6] = new List<Move>() { new Shadowsneak() },
			[12] = new List<Move>() { new Doubleteam() },
			[18] = new List<Move>() { new Babydolleyes() },
			[24] = new List<Move>() { new Mimic() },
			[30] = new List<Move>() { new Honeclaws() },
			[36] = new List<Move>() { new Slash() },
			[42] = new List<Move>() { new Shadowclaw() },
			[48] = new List<Move>() { new Charm() },
			[54] = new List<Move>() { new Playrough() },
			[60] = new List<Move>() { new Painsplit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Bulkup(), new Burningjealousy(), new Charm(), new Darkpulse(), new Dazzlinggleam(), new Drainingkiss(), new Drainpunch(), new Endure(), new Facade(), new Fling(), new Gigadrain(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Leechlife(), new Lightscreen(), new Magicroom(), new Payback(), new Phantomforce(), new Playrough(), new Protect(), new Psychic(), new Rest(), new Round(), new Safeguard(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Swordsdance(), new Taunt(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Willowisp(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Destinybond(), new Grudge() };
		public override int Weight => 7;
		public override int ExpYield => 167;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}