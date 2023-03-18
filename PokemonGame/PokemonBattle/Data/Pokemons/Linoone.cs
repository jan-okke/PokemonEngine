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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Quickfeet() };
		public override Stats BaseStats => new Stats(78, 70, 61, 50, 61, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Slash() },
			[1] = new List<Move>() { new Moves.Slash(), new Moves.Switcheroo(), new Moves.Pinmissile(), new Moves.Babydolleyes(), new Moves.Tackle(), new Moves.Growl(), new Moves.Sandattack(), new Moves.Tailwhip() },
			[9] = new List<Move>() { new Moves.Covet() },
			[12] = new List<Move>() { new Moves.Headbutt() },
			[15] = new List<Move>() { new Moves.Honeclaws() },
			[18] = new List<Move>() { new Moves.Furyswipes() },
			[23] = new List<Move>() { new Moves.Rest() },
			[28] = new List<Move>() { new Moves.Takedown() },
			[33] = new List<Move>() { new Moves.Fling() },
			[38] = new List<Move>() { new Moves.Flail() },
			[43] = new List<Move>() { new Moves.Bellydrum() },
			[48] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Mudshot(), new Moves.Pinmissile(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Workup() };
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