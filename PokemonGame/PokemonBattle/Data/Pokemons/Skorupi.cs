using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skorupi : Pokemon
	{
		public override string Name => "Skorupi";
		public override List<Ability> AvailableAbilities => new() {new Battlearmor(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Keeneye() };
		public override Stats BaseStats => new Stats(40, 50, 90, 65, 30, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Leer() },
			[3] = new List<Move>() { new Honeclaws() },
			[6] = new List<Move>() { new Fellstinger() },
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
			[42] = new List<Move>() { new Xscissor() },
			[45] = new List<Move>() { new Acupressure() },
			[48] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Brickbreak(), new Bugbuzz(), new Crosspoison(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Fling(), new Hiddenpower(), new Irontail(), new Payback(), new Pinmissile(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Screech(), new Shadowball(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Torment(), new Toxic(), new Toxicspikes(), new Venoshock(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Confuseray(), new Nightslash(), new Poisontail(), new Sandattack(), new Screech(), new Slash(), new Whirlwind() };
		public override int Weight => 120;
		public override int ExpYield => 66;
		public override int CatchRate => 120;
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