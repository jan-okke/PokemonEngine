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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Disguise() };
		public override Stats BaseStats => new Stats(55, 90, 80, 50, 105, 96);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Woodhammer(), new Moves.Splash(), new Moves.Astonish(), new Moves.Scratch(), new Moves.Copycat() },
			[6] = new List<Move>() { new Moves.Shadowsneak() },
			[12] = new List<Move>() { new Moves.Doubleteam() },
			[18] = new List<Move>() { new Moves.Babydolleyes() },
			[24] = new List<Move>() { new Moves.Mimic() },
			[30] = new List<Move>() { new Moves.Honeclaws() },
			[36] = new List<Move>() { new Moves.Slash() },
			[42] = new List<Move>() { new Moves.Shadowclaw() },
			[48] = new List<Move>() { new Moves.Charm() },
			[54] = new List<Move>() { new Moves.Playrough() },
			[60] = new List<Move>() { new Moves.Painsplit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Bulkup(), new Moves.Burningjealousy(), new Moves.Charm(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Workup(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Destinybond(), new Moves.Grudge() };
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