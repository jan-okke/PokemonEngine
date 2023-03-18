using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tyrunt : Pokemon
	{
		public override string Name => "Tyrunt";
		public override List<Ability> AvailableAbilities => new() {new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(58, 89, 77, 48, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[4] = new List<Move>() { new Roar() },
			[8] = new List<Move>() { new Ancientpower() },
			[12] = new List<Move>() { new Charm() },
			[16] = new List<Move>() { new Bite() },
			[20] = new List<Move>() { new Dragontail() },
			[24] = new List<Move>() { new Stomp() },
			[28] = new List<Move>() { new Rockslide() },
			[32] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Dragonclaw() },
			[40] = new List<Move>() { new Thrash() },
			[44] = new List<Move>() { new Earthquake() },
			[48] = new List<Move>() { new Horndrill() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Charm(), new Closecombat(), new Crunch(), new Darkpulse(), new Dig(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firefang(), new Hiddenpower(), new Hypervoice(), new Icefang(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Meteorbeam(), new Outrage(), new Playrough(), new Protect(), new Psychicfangs(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Thunderfang(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Poisonfang(), new Rockpolish(), new Rockthrow() };
		public override int Weight => 260;
		public override int ExpYield => 72;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}