using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Komala : Pokemon
{
	public override string Name => "Komala";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Comatose() };
	public override Stats BaseStats => new Stats(65, 115, 65, 75, 95, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Defensecurl(), new Moves.Rollout() },
		[6] = new List<Move>() { new Moves.Stockpile(), new Moves.Spitup(), new Moves.Swallow() },
		[11] = new List<Move>() { new Moves.Rapidspin() },
		[16] = new List<Move>() { new Moves.Yawn() },
		[21] = new List<Move>() { new Moves.Slam() },
		[26] = new List<Move>() { new Moves.Flail() },
		[31] = new List<Move>() { new Moves.Suckerpunch() },
		[36] = new List<Move>() { new Moves.Psychup() },
		[41] = new List<Move>() { new Moves.Woodhammer() },
		[46] = new List<Move>() { new Moves.Thrash() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Frustration(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Lowsweep(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Quash(), new Moves.Return(), new Moves.Rockslide(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Charm(), new Moves.Playrough(), new Moves.Sing(), new Moves.Wish() };
	public override int Weight => 199;
	public override int ExpYield => 168;
	public override int CatchRate => 45;
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