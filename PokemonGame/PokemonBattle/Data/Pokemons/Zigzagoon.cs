using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zigzagoon : Pokemon
	{
		public override string Name => "Zigzagoon";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Quickfeet() };
		public override Stats BaseStats => new Stats(38, 30, 41, 60, 30, 41);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[3] = new List<Move>() { new Sandattack() },
			[6] = new List<Move>() { new Tailwhip() },
			[9] = new List<Move>() { new Covet() },
			[12] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Babydolleyes() },
			[18] = new List<Move>() { new Pinmissile() },
			[21] = new List<Move>() { new Rest() },
			[24] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Fling() },
			[30] = new List<Move>() { new Flail() },
			[33] = new List<Move>() { new Bellydrum() },
			[36] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Chargebeam(), new Charm(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fling(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Mudshot(), new Pinmissile(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Tailslap(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Extremespeed(), new Helpinghand(), new Mudslap(), new Simplebeam(), new Tickle(), new Trick() };
		public override int Weight => 175;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}