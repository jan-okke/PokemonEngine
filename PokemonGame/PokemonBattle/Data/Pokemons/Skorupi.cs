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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor(), new Abilities.Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Keeneye() };
		public override Stats BaseStats => new Stats(40, 50, 90, 30, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Leer() },
			[3] = new List<Move>() { new Moves.Honeclaws() },
			[6] = new List<Move>() { new Moves.Fellstinger() },
			[9] = new List<Move>() { new Moves.Poisonfang() },
			[12] = new List<Move>() { new Moves.Bite() },
			[15] = new List<Move>() { new Moves.Toxicspikes() },
			[18] = new List<Move>() { new Moves.Bugbite() },
			[21] = new List<Move>() { new Moves.Venoshock() },
			[24] = new List<Move>() { new Moves.Knockoff() },
			[27] = new List<Move>() { new Moves.Scaryface() },
			[30] = new List<Move>() { new Moves.Pinmissile() },
			[33] = new List<Move>() { new Moves.Toxic() },
			[36] = new List<Move>() { new Moves.Nightslash() },
			[39] = new List<Move>() { new Moves.Crosspoison() },
			[42] = new List<Move>() { new Moves.Xscissor() },
			[45] = new List<Move>() { new Moves.Acupressure() },
			[48] = new List<Move>() { new Moves.Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Fling(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venoshock(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Agility(), new Moves.Confuseray(), new Moves.Nightslash(), new Moves.Poisontail(), new Moves.Sandattack(), new Moves.Screech(), new Moves.Slash(), new Moves.Whirlwind() };
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