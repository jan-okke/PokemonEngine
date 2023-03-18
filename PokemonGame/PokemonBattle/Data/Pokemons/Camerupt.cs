using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Camerupt : Pokemon
	{
		public override string Name => "Camerupt";
		public override List<Ability> AvailableAbilities => new() {new Magmaarmor(), new Solidrock() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Angerpoint() };
		public override Stats BaseStats => new Stats(70, 100, 70, 105, 75, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Rockslide() },
			[1] = new List<Move>() { new Rockslide(), new Fissure(), new Eruption(), new Growl(), new Tackle(), new Ember(), new Focusenergy() },
			[8] = new List<Move>() { new Ember(), new Focusenergy() },
			[12] = new List<Move>() { new Bulldoze() },
			[15] = new List<Move>() { new Flamewheel() },
			[19] = new List<Move>() { new Amnesia() },
			[22] = new List<Move>() { new Lavaplume() },
			[26] = new List<Move>() { new Earthpower() },
			[29] = new List<Move>() { new Curse() },
			[31] = new List<Move>() { new Takedown() },
			[39] = new List<Move>() { new Yawn() },
			[46] = new List<Move>() { new Earthquake() },
			[52] = new List<Move>() { new Eruption() },
			[59] = new List<Move>() { new Fissure() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Echoedvoice(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Flashcannon(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Naturepower(), new Overheat(), new Protect(), new Rest(), new Return(), new Roar(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Willowisp() };
		public override int Weight => 2200;
		public override int ExpYield => 161;
		public override int CatchRate => 150;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}