using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Moltres : Pokemon
{
	public override string Name => "Moltres";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flamebody() };
	public override Stats BaseStats => new Stats(90, 100, 90, 125, 85, 90);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Leer() },
		[5] = new List<Move>() { new Moves.Ember() },
		[10] = new List<Move>() { new Moves.Safeguard() },
		[15] = new List<Move>() { new Moves.Wingattack() },
		[20] = new List<Move>() { new Moves.Agility() },
		[25] = new List<Move>() { new Moves.Ancientpower() },
		[30] = new List<Move>() { new Moves.Incinerate() },
		[35] = new List<Move>() { new Moves.Airslash() },
		[40] = new List<Move>() { new Moves.Roost() },
		[45] = new List<Move>() { new Moves.Heatwave() },
		[50] = new List<Move>() { new Moves.Sunnyday() },
		[55] = new List<Move>() { new Moves.Hurricane() },
		[60] = new List<Move>() { new Moves.Endure() },
		[65] = new List<Move>() { new Moves.Burnup() },
		[70] = new List<Move>() { new Moves.Skyattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Bravebird(), new Moves.Burningjealousy(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scorchingsands(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Uturn(), new Moves.Weatherball(), new Moves.Willowisp() };
	public override int Weight => 600;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}