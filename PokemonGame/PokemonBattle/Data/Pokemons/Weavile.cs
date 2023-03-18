using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Weavile : Pokemon
	{
		public override string Name => "Weavile";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Pickpocket() };
		public override Stats BaseStats => new Stats(70, 120, 65, 125, 45, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Revenge(), new Assurance(), new Quickattack(), new Beatup(), new Agility(), new Slash(), new Scratch(), new Leer(), new Taunt(), new Iceshard() },
			[18] = new List<Move>() { new Metalclaw() },
			[24] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Furyswipes() },
			[36] = new List<Move>() { new Honeclaws() },
			[42] = new List<Move>() { new Fling() },
			[48] = new List<Move>() { new Nastyplot() },
			[54] = new List<Move>() { new Screech() },
			[60] = new List<Move>() { new Nightslash() },
			[66] = new List<Move>() { new Darkpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Avalanche(), new Beatup(), new Blizzard(), new Brickbreak(), new Calmmind(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Falseswipe(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Irontail(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Poisonjab(), new Protect(), new Psychocut(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Revenge(), new Rocksmash(), new Round(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snarl(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Tripleaxel(), new Whirlpool(), new Xscissor() };
		public override int Weight => 340;
		public override int ExpYield => 179;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}