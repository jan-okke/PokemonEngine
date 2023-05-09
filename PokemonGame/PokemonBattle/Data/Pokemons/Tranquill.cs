using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tranquill : Pokemon
{
	public override string Name => "Tranquill";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Bigpecks(), new Abilities.Superluck() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rivalry() };
	public override Stats BaseStats => new Stats(62, 77, 62, 50, 42, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Growl(), new Moves.Leer(), new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Taunt() },
		[16] = new List<Move>() { new Moves.Aircutter() },
		[20] = new List<Move>() { new Moves.Swagger() },
		[26] = new List<Move>() { new Moves.Featherdance() },
		[34] = new List<Move>() { new Moves.Detect() },
		[38] = new List<Move>() { new Moves.Airslash() },
		[44] = new List<Move>() { new Moves.Roost() },
		[50] = new List<Move>() { new Moves.Tailwind() },
		[56] = new List<Move>() { new Moves.Skyattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 150;
	public override int ExpYield => 125;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}