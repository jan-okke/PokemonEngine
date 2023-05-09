using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Weavile : Pokemon
{
	public override string Name => "Weavile";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Pickpocket() };
	public override Stats BaseStats => new Stats(70, 120, 65, 45, 85, 125);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Revenge(), new Moves.Assurance(), new Moves.Quickattack(), new Moves.Beatup(), new Moves.Agility(), new Moves.Slash(), new Moves.Scratch(), new Moves.Leer(), new Moves.Taunt(), new Moves.Iceshard() },
		[18] = new List<Move>() { new Moves.Metalclaw() },
		[24] = new List<Move>() { new Moves.Icywind() },
		[30] = new List<Move>() { new Moves.Furyswipes() },
		[36] = new List<Move>() { new Moves.Honeclaws() },
		[42] = new List<Move>() { new Moves.Fling() },
		[48] = new List<Move>() { new Moves.Nastyplot() },
		[54] = new List<Move>() { new Moves.Screech() },
		[60] = new List<Move>() { new Moves.Nightslash() },
		[66] = new List<Move>() { new Moves.Darkpulse() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Tripleaxel(), new Moves.Whirlpool(), new Moves.Xscissor() };
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