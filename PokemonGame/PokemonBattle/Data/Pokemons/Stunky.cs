using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Stunky : Pokemon
{
	public override string Name => "Stunky";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Stench(), new Abilities.Aftermath() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Keeneye() };
	public override Stats BaseStats => new Stats(63, 63, 47, 41, 41, 74);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Poisongas(), new Moves.Scratch() },
		[3] = new List<Move>() { new Moves.Feint() },
		[6] = new List<Move>() { new Moves.Smokescreen() },
		[9] = new List<Move>() { new Moves.Acidspray() },
		[12] = new List<Move>() { new Moves.Furyswipes() },
		[15] = new List<Move>() { new Moves.Focusenergy() },
		[18] = new List<Move>() { new Moves.Bite() },
		[21] = new List<Move>() { new Moves.Venoshock() },
		[24] = new List<Move>() { new Moves.Screech() },
		[27] = new List<Move>() { new Moves.Toxic() },
		[30] = new List<Move>() { new Moves.Suckerpunch() },
		[33] = new List<Move>() { new Moves.Memento() },
		[36] = new List<Move>() { new Moves.Nightslash() },
		[39] = new List<Move>() { new Moves.Belch() },
		[42] = new List<Move>() { new Moves.Venomdrench() },
		[45] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Corrosivegas(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Focusenergy(), new Moves.Foulplay(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Toxic(), new Moves.Venomdrench(), new Moves.Venoshock() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Crunch(), new Moves.Doubleedge(), new Moves.Foulplay(), new Moves.Haze(), new Moves.Leer(), new Moves.Playrough(), new Moves.Scaryface(), new Moves.Slash(), new Moves.Smog() };
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