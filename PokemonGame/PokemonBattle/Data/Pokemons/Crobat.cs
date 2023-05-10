using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Crobat : Pokemon
{
	public override string Name => "Crobat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(85, 90, 80, 70, 80, 130);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Crosspoison() },
		[1] = new List<Move>() { new Moves.Crosspoison(), new Moves.Tailwind(), new Moves.Toxic(), new Moves.Screech(), new Moves.Absorb(), new Moves.Supersonic(), new Moves.Astonish(), new Moves.Meanlook() },
		[15] = new List<Move>() { new Moves.Poisonfang() },
		[20] = new List<Move>() { new Moves.Quickguard() },
		[27] = new List<Move>() { new Moves.Aircutter() },
		[34] = new List<Move>() { new Moves.Bite() },
		[41] = new List<Move>() { new Moves.Haze() },
		[48] = new List<Move>() { new Moves.Venoshock() },
		[55] = new List<Move>() { new Moves.Confuseray() },
		[62] = new List<Move>() { new Moves.Airslash() },
		[69] = new List<Move>() { new Moves.Leechlife() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Crosspoison(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 750;
	public override int ExpYield => 268;
	public override int CatchRate => 90;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 3
	};
}