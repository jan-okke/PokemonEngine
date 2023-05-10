using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Camerupt : Pokemon
{
	public override string Name => "Camerupt";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Magmaarmor(), new Abilities.Solidrock() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Angerpoint() };
	public override Stats BaseStats => new Stats(70, 100, 70, 105, 75, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ground };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Rockslide() },
		[1] = new List<Move>() { new Moves.Rockslide(), new Moves.Fissure(), new Moves.Eruption(), new Moves.Growl(), new Moves.Tackle(), new Moves.Ember(), new Moves.Focusenergy() },
		[8] = new List<Move>() { new Moves.Ember(), new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Bulldoze() },
		[15] = new List<Move>() { new Moves.Flamewheel() },
		[19] = new List<Move>() { new Moves.Amnesia() },
		[22] = new List<Move>() { new Moves.Lavaplume() },
		[26] = new List<Move>() { new Moves.Earthpower() },
		[29] = new List<Move>() { new Moves.Curse() },
		[31] = new List<Move>() { new Moves.Takedown() },
		[39] = new List<Move>() { new Moves.Yawn() },
		[46] = new List<Move>() { new Moves.Earthquake() },
		[52] = new List<Move>() { new Moves.Eruption() },
		[59] = new List<Move>() { new Moves.Fissure() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Naturepower(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Roar(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Willowisp() };
	public override int Weight => 2200;
	public override int ExpYield => 161;
	public override int CatchRate => 150;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}