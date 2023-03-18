using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skitty : Pokemon
	{
		public override string Name => "Skitty";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Normalize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Wonderskin() };
		public override Stats BaseStats => new Stats(50, 45, 45, 35, 35, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fakeout(), new Growl(), new Tailwhip() },
			[4] = new List<Move>() { new Tackle() },
			[7] = new List<Move>() { new Sing() },
			[10] = new List<Move>() { new Attract() },
			[13] = new List<Move>() { new Disarmingvoice() },
			[16] = new List<Move>() { new Furyswipes() },
			[19] = new List<Move>() { new Copycat() },
			[22] = new List<Move>() { new Payback() },
			[25] = new List<Move>() { new Charm() },
			[31] = new List<Move>() { new Facade() },
			[34] = new List<Move>() { new Covet() },
			[37] = new List<Move>() { new Healbell() },
			[40] = new List<Move>() { new Doubleedge() },
			[43] = new List<Move>() { new Babydolleyes() },
			[46] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Dig(), new Doubleteam(), new Dreameater(), new Echoedvoice(), new Endure(), new Facade(), new Flash(), new Frustration(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icywind(), new Irontail(), new Lastresort(), new Nastyplot(), new Payback(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Cosmicpower(), new Fakeout(), new Faketears(), new Helpinghand(), new Lastresort(), new Simplebeam(), new Suckerpunch(), new Tickle(), new Uproar(), new Wish(), new Zenheadbutt() };
		public override int Weight => 110;
		public override int ExpYield => 52;
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