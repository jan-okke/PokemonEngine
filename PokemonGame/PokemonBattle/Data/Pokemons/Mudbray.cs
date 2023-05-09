using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Mudbray : Pokemon
{
	public override string Name => "Mudbray";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Owntempo(), new Abilities.Stamina() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
	public override Stats BaseStats => new Stats(70, 100, 70, 45, 55, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Rocksmash() },
		[4] = new List<Move>() { new Moves.Irondefense() },
		[8] = new List<Move>() { new Moves.Doublekick() },
		[12] = new List<Move>() { new Moves.Bulldoze() },
		[16] = new List<Move>() { new Moves.Stomp() },
		[20] = new List<Move>() { new Moves.Strength() },
		[24] = new List<Move>() { new Moves.Counter() },
		[28] = new List<Move>() { new Moves.Highhorsepower() },
		[32] = new List<Move>() { new Moves.Heavyslam() },
		[36] = new List<Move>() { new Moves.Earthquake() },
		[40] = new List<Move>() { new Moves.Megakick() },
		[44] = new List<Move>() { new Moves.Superpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Closecombat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Fissure(), new Moves.Roar(), new Moves.Smackdown() };
	public override int Weight => 1100;
	public override int ExpYield => 77;
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