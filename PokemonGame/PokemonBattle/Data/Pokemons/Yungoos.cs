using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yungoos : Pokemon
	{
		public override string Name => "Yungoos";
		public override List<Ability> AvailableAbilities => new() {new Stakeout(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(48, 70, 30, 30, 30, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[3] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Pursuit() },
			[10] = new List<Move>() { new Sandattack() },
			[13] = new List<Move>() { new Odorsleuth() },
			[16] = new List<Move>() { new Bide() },
			[19] = new List<Move>() { new Bite() },
			[22] = new List<Move>() { new Mudslap() },
			[25] = new List<Move>() { new Superfang() },
			[28] = new List<Move>() { new Takedown() },
			[31] = new List<Move>() { new Scaryface() },
			[34] = new List<Move>() { new Crunch() },
			[37] = new List<Move>() { new Hyperfang() },
			[40] = new List<Move>() { new Yawn() },
			[43] = new List<Move>() { new Thrash() },
			[46] = new List<Move>() { new Rest() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Confide(), new Doubleteam(), new Earthquake(), new Echoedvoice(), new Endeavor(), new Facade(), new Frustration(), new Hiddenpower(), new Irontail(), new Lastresort(), new Payback(), new Protect(), new Rest(), new Return(), new Rocktomb(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Substitute(), new Superfang(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Toxic(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Firefang(), new Icefang(), new Lastresort(), new Revenge(), new Thunderfang() };
		public override int Weight => 60;
		public override int ExpYield => 51;
		public override int CatchRate => 255;
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