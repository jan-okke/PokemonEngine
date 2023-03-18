using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golem : Pokemon
	{
		public override string Name => "Golem";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(80, 120, 130, 55, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Heavyslam(), new Tackle(), new Defensecurl(), new Rockpolish() },
			[4] = new List<Move>() { new Sandstorm() },
			[6] = new List<Move>() { new Rockpolish() },
			[10] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Harden() },
			[16] = new List<Move>() { new Rockthrow() },
			[18] = new List<Move>() { new Smackdown() },
			[22] = new List<Move>() { new Bulldoze() },
			[24] = new List<Move>() { new Selfdestruct() },
			[30] = new List<Move>() { new Stealthrock() },
			[34] = new List<Move>() { new Rockblast() },
			[40] = new List<Move>() { new Earthquake() },
			[44] = new List<Move>() { new Explosion() },
			[50] = new List<Move>() { new Doubleedge() },
			[54] = new List<Move>() { new Stoneedge() },
			[60] = new List<Move>() { new Heavyslam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Brickbreak(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Naturepower(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Roar(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thunderpunch() };
		public override int Weight => 3000;
		public override int ExpYield => 248;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}