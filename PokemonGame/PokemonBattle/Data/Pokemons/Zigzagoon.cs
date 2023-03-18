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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Quickfeet() };
		public override Stats BaseStats => new Stats(38, 30, 41, 30, 41, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
			[3] = new List<Move>() { new Moves.Sandattack() },
			[6] = new List<Move>() { new Moves.Tailwhip() },
			[9] = new List<Move>() { new Moves.Covet() },
			[12] = new List<Move>() { new Moves.Headbutt() },
			[15] = new List<Move>() { new Moves.Babydolleyes() },
			[18] = new List<Move>() { new Moves.Pinmissile() },
			[21] = new List<Move>() { new Moves.Rest() },
			[24] = new List<Move>() { new Moves.Takedown() },
			[27] = new List<Move>() { new Moves.Fling() },
			[30] = new List<Move>() { new Moves.Flail() },
			[33] = new List<Move>() { new Moves.Bellydrum() },
			[36] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Charm(), new Moves.Extremespeed(), new Moves.Helpinghand(), new Moves.Mudslap(), new Moves.Simplebeam(), new Moves.Tickle(), new Moves.Trick() };
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