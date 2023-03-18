using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Linoone : Pokemon
	{
		public override string Name => "Linoone";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Quickfeet() };
		public override Stats BaseStats => new Stats(78, 70, 61, 100, 50, 61);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Switcheroo(), new Pinmissile(), new Babydolleyes(), new Tackle(), new Growl(), new Sandattack(), new Tailwhip() },
			[9] = new List<Move>() { new Covet() },
			[12] = new List<Move>() { new Headbutt() },
			[15] = new List<Move>() { new Honeclaws() },
			[18] = new List<Move>() { new Furyswipes() },
			[23] = new List<Move>() { new Rest() },
			[28] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Fling() },
			[38] = new List<Move>() { new Flail() },
			[43] = new List<Move>() { new Bellydrum() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Bodyslam(), new Chargebeam(), new Charm(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Facade(), new Fling(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Mudshot(), new Pinmissile(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Roar(), new Rocksmash(), new Round(), new Seedbomb(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Tailslap(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Waterpulse(), new Whirlpool(), new Workup() };
		public override int Weight => 325;
		public override int ExpYield => 147;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}