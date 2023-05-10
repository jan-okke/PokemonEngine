using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Stufful : Pokemon
{
	public override string Name => "Stufful";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Fluffy(), new Abilities.Klutz() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cutecharm() };
	public override Stats BaseStats => new Stats(70, 75, 50, 45, 50, 50);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fighting };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
		[4] = new List<Move>() { new Moves.Babydolleyes() },
		[8] = new List<Move>() { new Moves.Payback() },
		[12] = new List<Move>() { new Moves.Brutalswing() },
		[16] = new List<Move>() { new Moves.Endure() },
		[20] = new List<Move>() { new Moves.Strength() },
		[24] = new List<Move>() { new Moves.Takedown() },
		[28] = new List<Move>() { new Moves.Flail() },
		[32] = new List<Move>() { new Moves.Hammerarm() },
		[36] = new List<Move>() { new Moves.Thrash() },
		[40] = new List<Move>() { new Moves.Painsplit() },
		[44] = new List<Move>() { new Moves.Doubleedge() },
		[48] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Charm(), new Moves.Coaching(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Ironhead(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Defensecurl(), new Moves.Forcepalm(), new Moves.Rollout(), new Moves.Stomp() };
	public override int Weight => 68;
	public override int ExpYield => 68;
	public override int CatchRate => 140;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}