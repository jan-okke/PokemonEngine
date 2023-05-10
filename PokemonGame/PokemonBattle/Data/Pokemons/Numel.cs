using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Numel : Pokemon
{
	public override string Name => "Numel";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Simple() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Owntempo() };
	public override Stats BaseStats => new Stats(60, 60, 40, 65, 45, 35);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Tackle() },
		[5] = new List<Move>() { new Moves.Ember() },
		[8] = new List<Move>() { new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Bulldoze() },
		[15] = new List<Move>() { new Moves.Flamewheel() },
		[19] = new List<Move>() { new Moves.Amnesia() },
		[22] = new List<Move>() { new Moves.Lavaplume() },
		[26] = new List<Move>() { new Moves.Earthpower() },
		[29] = new List<Move>() { new Moves.Curse() },
		[31] = new List<Move>() { new Moves.Takedown() },
		[36] = new List<Move>() { new Moves.Yawn() },
		[40] = new List<Move>() { new Moves.Earthquake() },
		[43] = new List<Move>() { new Moves.Flamethrower() },
		[47] = new List<Move>() { new Moves.Doubleedge() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Ironhead(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Willowisp() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Bodyslam(), new Moves.Defensecurl(), new Moves.Growth(), new Moves.Heatwave(), new Moves.Heavyslam(), new Moves.Howl(), new Moves.Ironhead(), new Moves.Rollout(), new Moves.Scaryface(), new Moves.Spitup(), new Moves.Stockpile(), new Moves.Stomp(), new Moves.Swallow(), new Moves.Yawn() };
	public override int Weight => 240;
	public override int ExpYield => 61;
	public override int CatchRate => 255;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}