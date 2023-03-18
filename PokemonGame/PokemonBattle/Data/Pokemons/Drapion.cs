using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drapion : Pokemon
	{
		public override string Name => "Drapion";
		public override List<Ability> AvailableAbilities => new() {new Battlearmor(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Keeneye() };
		public override Stats BaseStats => new Stats(70, 90, 110, 95, 60, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Thunderfang(), new Icefang(), new Firefang(), new Poisonsting(), new Leer(), new Honeclaws(), new Fellstinger() },
			[9] = new List<Move>() { new Poisonfang() },
			[12] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Toxicspikes() },
			[18] = new List<Move>() { new Bugbite() },
			[21] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Knockoff() },
			[27] = new List<Move>() { new Scaryface() },
			[30] = new List<Move>() { new Pinmissile() },
			[33] = new List<Move>() { new Toxic() },
			[36] = new List<Move>() { new Nightslash() },
			[39] = new List<Move>() { new Crosspoison() },
			[44] = new List<Move>() { new Xscissor() },
			[49] = new List<Move>() { new Acupressure() },
			[54] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Brickbreak(), new Brutalswing(), new Bugbuzz(), new Bulldoze(), new Crosspoison(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Firefang(), new Flash(), new Fling(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icefang(), new Irondefense(), new Irontail(), new Lashout(), new Leechlife(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandtomb(), new Scaryface(), new Screech(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderfang(), new Torment(), new Toxic(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Xscissor() };
		public override int Weight => 615;
		public override int ExpYield => 175;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}