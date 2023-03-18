using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Steelix : Pokemon
	{
		public override string Name => "Steelix";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sheerforce() };
		public override Stats BaseStats => new Stats(75, 85, 200, 30, 55, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Crunch(), new Thunderfang(), new Icefang(), new Firefang(), new Rockpolish(), new Tackle(), new Harden(), new Bind(), new Rockthrow() },
			[4] = new List<Move>() { new Smackdown() },
			[8] = new List<Move>() { new Autotomize() },
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
			[60] = new List<Move>() { new Magnetrise() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Drillrun(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Firefang(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icefang(), new Irondefense(), new Ironhead(), new Irontail(), new Meteorbeam(), new Payback(), new Protect(), new Psychicfangs(), new Psychup(), new Rest(), new Roar(), new Rockblast(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Scaryface(), new Scorchingsands(), new Screech(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thunderfang(), new Torment() };
		public override int Weight => 4000;
		public override int ExpYield => 179;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}