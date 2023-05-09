using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Slugma : Pokemon
{
	public override string Name => "Slugma";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Magmaarmor(), new Abilities.Flamebody() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(40, 40, 40, 70, 40, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Yawn(), new Moves.Smog() },
		[6] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Rockthrow() },
		[13] = new List<Move>() { new Moves.Harden() },
		[15] = new List<Move>() { new Moves.Incinerate() },
		[20] = new List<Move>() { new Moves.Clearsmog() },
		[22] = new List<Move>() { new Moves.Ancientpower() },
		[29] = new List<Move>() { new Moves.Rockslide() },
		[34] = new List<Move>() { new Moves.Lavaplume() },
		[36] = new List<Move>() { new Moves.Amnesia() },
		[41] = new List<Move>() { new Moves.Bodyslam() },
		[43] = new List<Move>() { new Moves.Recover() },
		[48] = new List<Move>() { new Moves.Flamethrower() },
		[50] = new List<Move>() { new Moves.Earthpower() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Confide(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Painsplit(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Curse(), new Moves.Earthpower(), new Moves.Guardswap(), new Moves.Heatwave(), new Moves.Inferno(), new Moves.Memento(), new Moves.Rollout(), new Moves.Smokescreen(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Swallow() };
	public override int Weight => 350;
	public override int ExpYield => 50;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}