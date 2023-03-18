using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sneasel : Pokemon
	{
		public override string Name => "Sneasel";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(55, 95, 55, 35, 75, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Leer() },
			[6] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Quickattack() },
			[18] = new List<Move>() { new Metalclaw() },
			[24] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Furyswipes() },
			[36] = new List<Move>() { new Honeclaws() },
			[42] = new List<Move>() { new Beatup() },
			[48] = new List<Move>() { new Agility() },
			[54] = new List<Move>() { new Screech() },
			[60] = new List<Move>() { new Slash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Avalanche(), new Beatup(), new Blizzard(), new Brickbreak(), new Calmmind(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Falseswipe(), new Fling(), new Focuspunch(), new Foulplay(), new Hail(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Psychocut(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Rocksmash(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Tripleaxel(), new Whirlpool(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Bite(), new Counter(), new Crushclaw(), new Doublehit(), new Fakeout(), new Feint(), new Icepunch(), new Iceshard(), new Iciclecrash(), new Spite(), new Throatchop() };
		public override int Weight => 280;
		public override int ExpYield => 86;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}