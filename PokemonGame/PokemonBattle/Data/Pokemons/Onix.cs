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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Rockhead(), new Abilities.Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
		public override Stats BaseStats => new Stats(35, 45, 160, 30, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden(), new Moves.Bind(), new Moves.Rockthrow() },
			[4] = new List<Move>() { new Moves.Smackdown() },
			[8] = new List<Move>() { new Moves.Rockpolish() },
			[12] = new List<Move>() { new Moves.Dragonbreath() },
			[16] = new List<Move>() { new Moves.Curse() },
			[20] = new List<Move>() { new Moves.Rockslide() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Sandtomb() },
			[32] = new List<Move>() { new Moves.Stealthrock() },
			[36] = new List<Move>() { new Moves.Slam() },
			[40] = new List<Move>() { new Moves.Sandstorm() },
			[44] = new List<Move>() { new Moves.Dig() },
			[48] = new List<Move>() { new Moves.Irontail() },
			[52] = new List<Move>() { new Moves.Stoneedge() },
			[56] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drillrun(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Meteorbeam(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockblast(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Torment() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Defensecurl(), new Moves.Dragontail(), new Moves.Flail(), new Moves.Headsmash(), new Moves.Heavyslam(), new Moves.Rockblast(), new Moves.Rollout(), new Moves.Wideguard() };
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