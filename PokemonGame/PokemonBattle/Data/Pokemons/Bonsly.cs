using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Bonsly : Pokemon
{
	public override string Name => "Bonsly";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Rockhead() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Rattled() };
	public override Stats BaseStats => new Stats(50, 80, 95, 10, 45, 10);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Faketears(), new Moves.Copycat() },
		[4] = new List<Move>() { new Moves.Flail() },
		[8] = new List<Move>() { new Moves.Rockthrow() },
		[12] = new List<Move>() { new Moves.Block() },
		[16] = new List<Move>() { new Moves.Mimic() },
		[20] = new List<Move>() { new Moves.Rocktomb() },
		[24] = new List<Move>() { new Moves.Tearfullook() },
		[28] = new List<Move>() { new Moves.Suckerpunch() },
		[32] = new List<Move>() { new Moves.Rockslide() },
		[36] = new List<Move>() { new Moves.Lowkick() },
		[40] = new List<Move>() { new Moves.Counter() },
		[44] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Faketears(), new Moves.Foulplay(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Lowkick(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Uproar() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Defensecurl(), new Moves.Harden(), new Moves.Headbutt(), new Moves.Rollout(), new Moves.Sandtomb(), new Moves.Selfdestruct() };
	public override int Weight => 150;
	public override int ExpYield => 58;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}