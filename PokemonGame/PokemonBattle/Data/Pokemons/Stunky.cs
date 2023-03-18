using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stunky : Pokemon
	{
		public override string Name => "Stunky";
		public override List<Ability> AvailableAbilities => new() {new Stench(), new Aftermath() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Keeneye() };
		public override Stats BaseStats => new Stats(63, 63, 47, 41, 41, 74);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisongas(), new Scratch() },
			[3] = new List<Move>() { new Feint() },
			[6] = new List<Move>() { new Smokescreen() },
			[9] = new List<Move>() { new Acidspray() },
			[12] = new List<Move>() { new Furyswipes() },
			[15] = new List<Move>() { new Focusenergy() },
			[18] = new List<Move>() { new Bite() },
			[21] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Screech() },
			[27] = new List<Move>() { new Toxic() },
			[30] = new List<Move>() { new Suckerpunch() },
			[33] = new List<Move>() { new Memento() },
			[36] = new List<Move>() { new Nightslash() },
			[39] = new List<Move>() { new Belch() },
			[42] = new List<Move>() { new Venomdrench() },
			[45] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Corrosivegas(), new Crunch(), new Cut(), new Darkpulse(), new Defog(), new Dig(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Flamethrower(), new Focusenergy(), new Foulplay(), new Hex(), new Hiddenpower(), new Irontail(), new Lashout(), new Nastyplot(), new Payback(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Round(), new Scaryface(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Tailslap(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Toxic(), new Venomdrench(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Crunch(), new Doubleedge(), new Foulplay(), new Haze(), new Leer(), new Playrough(), new Scaryface(), new Slash(), new Smog() };
		public override int Weight => 192;
		public override int ExpYield => 66;
		public override int CatchRate => 225;
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