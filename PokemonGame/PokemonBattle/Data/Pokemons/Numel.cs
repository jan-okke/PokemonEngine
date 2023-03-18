using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Numel : Pokemon
	{
		public override string Name => "Numel";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Simple() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Owntempo() };
		public override Stats BaseStats => new Stats(60, 60, 40, 65, 45, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Tackle() },
			[5] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Focusenergy() },
			[12] = new List<Move>() { new Bulldoze() },
			[15] = new List<Move>() { new Flamewheel() },
			[19] = new List<Move>() { new Amnesia() },
			[22] = new List<Move>() { new Lavaplume() },
			[26] = new List<Move>() { new Earthpower() },
			[29] = new List<Move>() { new Curse() },
			[31] = new List<Move>() { new Takedown() },
			[36] = new List<Move>() { new Yawn() },
			[40] = new List<Move>() { new Earthquake() },
			[43] = new List<Move>() { new Flamethrower() },
			[47] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Echoedvoice(), new Endure(), new Facade(), new Fireblast(), new Flamecharge(), new Flamethrower(), new Frustration(), new Heatwave(), new Hiddenpower(), new Ironhead(), new Naturepower(), new Overheat(), new Protect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Bodyslam(), new Defensecurl(), new Growth(), new Heatwave(), new Heavyslam(), new Howl(), new Ironhead(), new Rollout(), new Scaryface(), new Spitup(), new Stockpile(), new Stomp(), new Swallow(), new Yawn() };
		public override int Weight => 240;
		public override int ExpYield => 61;
		public override int CatchRate => 255;
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
}