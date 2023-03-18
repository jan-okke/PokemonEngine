using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Phanpy : Pokemon
	{
		public override string Name => "Phanpy";
		public override List<Ability> AvailableAbilities => new() {new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(90, 60, 60, 40, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Defensecurl() },
			[6] = new List<Move>() { new Flail() },
			[10] = new List<Move>() { new Rollout() },
			[15] = new List<Move>() { new Bulldoze() },
			[19] = new List<Move>() { new Endure() },
			[24] = new List<Move>() { new Slam() },
			[28] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Charm() },
			[37] = new List<Move>() { new Lastresort() },
			[42] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulldoze(), new Confide(), new Doubleteam(), new Earthpower(), new Earthquake(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Frustration(), new Gunkshot(), new Hiddenpower(), new Hypervoice(), new Irontail(), new Knockoff(), new Lastresort(), new Protect(), new Rest(), new Return(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Snore(), new Stealthrock(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Bodyslam(), new Counter(), new Endeavor(), new Fissure(), new Focusenergy(), new Headsmash(), new Heavyslam(), new Highhorsepower(), new Iceshard(), new Mudslap(), new Playrough(), new Snore() };
		public override int Weight => 335;
		public override int ExpYield => 66;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}