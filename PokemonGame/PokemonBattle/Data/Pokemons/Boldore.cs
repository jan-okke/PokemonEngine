using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Boldore : Pokemon
{
	public override string Name => "Boldore";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Weakarmor() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
	public override Stats BaseStats => new Stats(70, 105, 105, 50, 40, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Powergem() },
		[1] = new List<Move>() { new Moves.Powergem(), new Moves.Sandattack(), new Moves.Tackle(), new Moves.Harden(), new Moves.Stealthrock() },
		[12] = new List<Move>() { new Moves.Mudslap() },
		[16] = new List<Move>() { new Moves.Smackdown() },
		[20] = new List<Move>() { new Moves.Irondefense() },
		[24] = new List<Move>() { new Moves.Headbutt() },
		[30] = new List<Move>() { new Moves.Rockslide() },
		[36] = new List<Move>() { new Moves.Rockblast() },
		[42] = new List<Move>() { new Moves.Sandstorm() },
		[48] = new List<Move>() { new Moves.Stoneedge() },
		[54] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bulldoze(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Powergem(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute() };
	public override int Weight => 1020;
	public override int ExpYield => 137;
	public override int CatchRate => 120;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}