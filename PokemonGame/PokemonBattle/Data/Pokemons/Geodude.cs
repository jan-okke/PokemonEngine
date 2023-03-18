using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Geodude : Pokemon
	{
		public override string Name => "Geodude";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandveil() };
		public override Stats BaseStats => new Stats(40, 80, 100, 20, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Defensecurl() },
			[4] = new List<Move>() { new Sandstorm() },
			[6] = new List<Move>() { new Rockpolish() },
			[10] = new List<Move>() { new Rollout() },
			[12] = new List<Move>() { new Harden() },
			[16] = new List<Move>() { new Rockthrow() },
			[18] = new List<Move>() { new Smackdown() },
			[22] = new List<Move>() { new Bulldoze() },
			[24] = new List<Move>() { new Selfdestruct() },
			[28] = new List<Move>() { new Stealthrock() },
			[30] = new List<Move>() { new Rockblast() },
			[34] = new List<Move>() { new Earthquake() },
			[36] = new List<Move>() { new Explosion() },
			[40] = new List<Move>() { new Doubleedge() },
			[42] = new List<Move>() { new Stoneedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Brickbreak(), new Bulldoze(), new Confide(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Gyroball(), new Hiddenpower(), new Irondefense(), new Naturepower(), new Poweruppunch(), new Protect(), new Rest(), new Return(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sleeptalk(), new Smackdown(), new Snore(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Thunderpunch() };
		public override List<Move> EggMoves => new List<Move>() { new Autotomize(), new Block(), new Curse(), new Flail(), new Hammerarm(), new Megapunch(), new Wideguard() };
		public override int Weight => 200;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}