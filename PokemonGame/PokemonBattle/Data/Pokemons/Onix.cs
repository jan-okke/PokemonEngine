using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Onix : Pokemon
	{
		public override string Name => "Onix";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(35, 45, 160, 30, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden(), new Bind(), new Rockthrow() },
			[4] = new List<Move>() { new Smackdown() },
			[8] = new List<Move>() { new Rockpolish() },
			[12] = new List<Move>() { new Dragonbreath() },
			[16] = new List<Move>() { new Curse() },
			[20] = new List<Move>() { new Rockslide() },
			[24] = new List<Move>() { new Screech() },
			[28] = new List<Move>() { new Sandtomb() },
			[32] = new List<Move>() { new Stealthrock() },
			[36] = new List<Move>() { new Slam() },
			[40] = new List<Move>() { new Sandstorm() },
			[44] = new List<Move>() { new Dig() },
			[48] = new List<Move>() { new Irontail() },
			[52] = new List<Move>() { new Stoneedge() },
			[56] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Dig(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Flashcannon(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Ironhead(), new Irontail(), new Meteorbeam(), new Payback(), new Protect(), new Psychup(), new Rest(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Scorchingsands(), new Screech(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Torment() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Defensecurl(), new Dragontail(), new Flail(), new Headsmash(), new Heavyslam(), new Rockblast(), new Rollout(), new Wideguard() };
		public override int Weight => 2100;
		public override int ExpYield => 77;
		public override int CatchRate => 45;
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