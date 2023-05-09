using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Zubat : Pokemon
{
	public override string Name => "Zubat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Infiltrator() };
	public override Stats BaseStats => new Stats(40, 45, 35, 30, 40, 55);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Absorb(), new Moves.Supersonic() },
		[5] = new List<Move>() { new Moves.Astonish() },
		[10] = new List<Move>() { new Moves.Meanlook() },
		[15] = new List<Move>() { new Moves.Poisonfang() },
		[20] = new List<Move>() { new Moves.Quickguard() },
		[25] = new List<Move>() { new Moves.Aircutter() },
		[30] = new List<Move>() { new Moves.Bite() },
		[35] = new List<Move>() { new Moves.Haze() },
		[40] = new List<Move>() { new Moves.Venoshock() },
		[45] = new List<Move>() { new Moves.Confuseray() },
		[50] = new List<Move>() { new Moves.Airslash() },
		[55] = new List<Move>() { new Moves.Leechlife() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Crunch(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigadrain(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Leechlife(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Bravebird(), new Moves.Curse(), new Moves.Gust(), new Moves.Hypnosis(), new Moves.Quickattack(), new Moves.Venomdrench(), new Moves.Whirlwind(), new Moves.Wingattack(), new Moves.Zenheadbutt() };
	public override int Weight => 75;
	public override int ExpYield => 49;
	public override int CatchRate => 255;
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