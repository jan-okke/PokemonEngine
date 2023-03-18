using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Donphan : Pokemon
	{
		public override string Name => "Donphan";
		public override List<Ability> AvailableAbilities => new() {new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(90, 120, 120, 60, 60, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Furyattack() },
			[1] = new List<Move>() { new Furyattack(), new Firefang(), new Thunderfang(), new Hornattack(), new Bulldoze(), new Growl(), new Defensecurl() },
			[6] = new List<Move>() { new Rapidspin() },
			[10] = new List<Move>() { new Rollout() },
			[15] = new List<Move>() { new Assurance() },
			[19] = new List<Move>() { new Knockoff() },
			[24] = new List<Move>() { new Slam() },
			[30] = new List<Move>() { new Rocktomb() },
			[37] = new List<Move>() { new Scaryface() },
			[43] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Bounce(), new Brutalswing(), new Bulldoze(), new Confide(), new Doubleteam(), new Earthpower(), new Earthquake(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Frustration(), new Gigaimpact(), new Gunkshot(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Irontail(), new Knockoff(), new Lastresort(), new Poisonjab(), new Protect(), new Rest(), new Return(), new Roar(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger() };
		public override int Weight => 1200;
		public override int ExpYield => 175;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}