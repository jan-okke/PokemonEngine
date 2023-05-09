using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Unfezant : Pokemon
{
	public override string Name => "Unfezant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Bigpecks(), new Abilities.Superluck() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rivalry() };
	public override Stats BaseStats => new Stats(80, 115, 80, 65, 55, 93);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Growl(), new Moves.Leer(), new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Taunt() },
		[16] = new List<Move>() { new Moves.Aircutter() },
		[20] = new List<Move>() { new Moves.Swagger() },
		[26] = new List<Move>() { new Moves.Featherdance() },
		[36] = new List<Move>() { new Moves.Detect() },
		[42] = new List<Move>() { new Moves.Airslash() },
		[50] = new List<Move>() { new Moves.Roost() },
		[58] = new List<Move>() { new Moves.Tailwind() },
		[66] = new List<Move>() { new Moves.Skyattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 290;
	public override int ExpYield => 244;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}