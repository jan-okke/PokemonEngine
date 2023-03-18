using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gumshoos : Pokemon
	{
		public override string Name => "Gumshoos";
		public override List<Ability> AvailableAbilities => new() {new Stakeout(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(88, 110, 60, 45, 55, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer(), new Pursuit(), new Sandattack() },
			[3] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Pursuit() },
			[10] = new List<Move>() { new Sandattack() },
			[13] = new List<Move>() { new Odorsleuth() },
			[16] = new List<Move>() { new Bide() },
			[19] = new List<Move>() { new Bite() },
			[23] = new List<Move>() { new Mudslap() },
			[27] = new List<Move>() { new Superfang() },
			[31] = new List<Move>() { new Takedown() },
			[35] = new List<Move>() { new Scaryface() },
			[39] = new List<Move>() { new Crunch() },
			[43] = new List<Move>() { new Hyperfang() },
			[47] = new List<Move>() { new Yawn() },
			[51] = new List<Move>() { new Thrash() },
			[55] = new List<Move>() { new Rest() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Block(), new Bulldoze(), new Confide(), new Doubleteam(), new Dualchop(), new Earthquake(), new Echoedvoice(), new Endeavor(), new Facade(), new Firepunch(), new Fling(), new Frustration(), new Hiddenpower(), new Icepunch(), new Ironhead(), new Irontail(), new Lastresort(), new Payback(), new Protect(), new Rest(), new Return(), new Roar(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Toxic(), new Uproar(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 142;
		public override int ExpYield => 146;
		public override int CatchRate => 127;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}