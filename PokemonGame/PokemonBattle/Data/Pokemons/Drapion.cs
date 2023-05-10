using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Drapion : Pokemon
{
	public override string Name => "Drapion";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Battlearmor(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Keeneye() };
	public override Stats BaseStats => new Stats(70, 90, 110, 60, 75, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dark };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Thunderfang(), new Moves.Icefang(), new Moves.Firefang(), new Moves.Poisonsting(), new Moves.Leer(), new Moves.Honeclaws(), new Moves.Fellstinger() },
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
		[44] = new List<Move>() { new Moves.Xscissor() },
		[49] = new List<Move>() { new Moves.Acupressure() },
		[54] = new List<Move>() { new Moves.Crunch() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bugbuzz(), new Moves.Bulldoze(), new Moves.Crosspoison(), new Moves.Crunch(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Firefang(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icefang(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Leechlife(), new Moves.Payback(), new Moves.Pinmissile(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderfang(), new Moves.Torment(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 615;
	public override int ExpYield => 175;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 2,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}