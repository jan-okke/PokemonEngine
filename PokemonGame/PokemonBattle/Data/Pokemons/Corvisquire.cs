using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Corvisquire : Pokemon
{
	public override string Name => "Corvisquire";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Unnerve() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Bigpecks() };
	public override Stats BaseStats => new Stats(68, 67, 55, 43, 55, 77);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Leer(), new Moves.Powertrip(), new Moves.Honeclaws() },
		[12] = new List<Move>() { new Moves.Furyattack() },
		[16] = new List<Move>() { new Moves.Pluck() },
		[22] = new List<Move>() { new Moves.Taunt() },
		[28] = new List<Move>() { new Moves.Scaryface() },
		[34] = new List<Move>() { new Moves.Drillpeck() },
		[40] = new List<Move>() { new Moves.Swagger() },
		[46] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bravebird(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Hiddenpower(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 160;
	public override int ExpYield => 128;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}