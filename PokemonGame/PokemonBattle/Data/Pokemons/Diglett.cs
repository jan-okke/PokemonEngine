using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Diglett : Pokemon
{
	public override string Name => "Diglett";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Sandveil(), new Abilities.Arenatrap() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sandforce() };
	public override Stats BaseStats => new Stats(10, 55, 25, 35, 45, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sandattack(), new Moves.Scratch() },
		[4] = new List<Move>() { new Moves.Growl() },
		[8] = new List<Move>() { new Moves.Astonish() },
		[12] = new List<Move>() { new Moves.Mudslap() },
		[16] = new List<Move>() { new Moves.Bulldoze() },
		[20] = new List<Move>() { new Moves.Suckerpunch() },
		[24] = new List<Move>() { new Moves.Slash() },
		[28] = new List<Move>() { new Moves.Sandstorm() },
		[32] = new List<Move>() { new Moves.Dig() },
		[36] = new List<Move>() { new Moves.Earthpower() },
		[40] = new List<Move>() { new Moves.Earthquake() },
		[44] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Hiddenpower(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Uproar(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Astonish(), new Moves.Beatup(), new Moves.Finalgambit(), new Moves.Headbutt(), new Moves.Honeclaws(), new Moves.Memento(), new Moves.Reversal(), new Moves.Screech(), new Moves.Uproar() };
	public override int Weight => 8;
	public override int ExpYield => 53;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}