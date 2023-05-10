using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Braviary : Pokemon
{
	public override string Name => "Braviary";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(100, 123, 75, 57, 75, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Superpower() },
		[1] = new List<Move>() { new Moves.Superpower(), new Moves.Skyattack(), new Moves.Peck(), new Moves.Leer(), new Moves.Honeclaws(), new Moves.Wingattack() },
		[18] = new List<Move>() { new Moves.Tailwind() },
		[24] = new List<Move>() { new Moves.Scaryface() },
		[30] = new List<Move>() { new Moves.Aerialace() },
		[36] = new List<Move>() { new Moves.Slash() },
		[42] = new List<Move>() { new Moves.Whirlwind() },
		[48] = new List<Move>() { new Moves.Crushclaw() },
		[57] = new List<Move>() { new Moves.Airslash() },
		[64] = new List<Move>() { new Moves.Defog() },
		[72] = new List<Move>() { new Moves.Thrash() },
		[80] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 410;
	public override int ExpYield => 179;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}