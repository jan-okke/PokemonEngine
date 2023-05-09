using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Rufflet : Pokemon
{
	public override string Name => "Rufflet";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Sheerforce() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
	public override Stats BaseStats => new Stats(70, 83, 50, 37, 50, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Wingattack() },
		[18] = new List<Move>() { new Moves.Tailwind() },
		[24] = new List<Move>() { new Moves.Scaryface() },
		[30] = new List<Move>() { new Moves.Aerialace() },
		[36] = new List<Move>() { new Moves.Slash() },
		[42] = new List<Move>() { new Moves.Whirlwind() },
		[48] = new List<Move>() { new Moves.Crushclaw() },
		[55] = new List<Move>() { new Moves.Airslash() },
		[60] = new List<Move>() { new Moves.Defog() },
		[66] = new List<Move>() { new Moves.Thrash() },
		[72] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Bulkup(), new Moves.Closecombat(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override int Weight => 105;
	public override int ExpYield => 70;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}