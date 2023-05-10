using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Patrat : Pokemon
{
	public override string Name => "Patrat";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Runaway(), new Abilities.Keeneye() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Analytic() };
	public override Stats BaseStats => new Stats(45, 55, 39, 35, 39, 42);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Tackle() },
		[3] = new List<Move>() { new Moves.Leer() },
		[6] = new List<Move>() { new Moves.Bite() },
		[8] = new List<Move>() { new Moves.Bide() },
		[11] = new List<Move>() { new Moves.Detect() },
		[13] = new List<Move>() { new Moves.Sandattack() },
		[16] = new List<Move>() { new Moves.Crunch() },
		[18] = new List<Move>() { new Moves.Hypnosis() },
		[21] = new List<Move>() { new Moves.Superfang() },
		[23] = new List<Move>() { new Moves.Afteryou() },
		[26] = new List<Move>() { new Moves.Focusenergy() },
		[28] = new List<Move>() { new Moves.Workup() },
		[31] = new List<Move>() { new Moves.Hyperfang() },
		[33] = new List<Move>() { new Moves.Nastyplot() },
		[36] = new List<Move>() { new Moves.Meanlook() },
		[38] = new List<Move>() { new Moves.Batonpass() },
		[41] = new List<Move>() { new Moves.Slam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Lowkick(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superfang(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thunderbolt(), new Moves.Toxic(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Assurance(), new Moves.Bulletseed(), new Moves.Flail(), new Moves.Foresight(), new Moves.Irontail(), new Moves.Pursuit(), new Moves.Revenge(), new Moves.Screech(), new Moves.Tearfullook() };
	public override int Weight => 116;
	public override int ExpYield => 51;
	public override int CatchRate => 255;
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