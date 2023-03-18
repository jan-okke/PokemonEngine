using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Buneary : Pokemon
	{
		public override string Name => "Buneary";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Limber() };
		public override Stats BaseStats => new Stats(55, 66, 44, 44, 56, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Pound() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Babydolleyes() },
			[12] = new List<Move>() { new Afteryou() },
			[16] = new List<Move>() { new Quickattack() },
			[20] = new List<Move>() { new Doublekick() },
			[24] = new List<Move>() { new Charm() },
			[28] = new List<Move>() { new Batonpass() },
			[32] = new List<Move>() { new Headbutt() },
			[36] = new List<Move>() { new Agility() },
			[40] = new List<Move>() { new Entrainment() },
			[44] = new List<Move>() { new Flatter() },
			[48] = new List<Move>() { new Bounce() },
			[52] = new List<Move>() { new Healingwish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Attract(), new Batonpass(), new Bounce(), new Chargebeam(), new Charm(), new Cosmicpower(), new Cut(), new Dig(), new Doubleteam(), new Drainpunch(), new Encore(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focuspunch(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icepunch(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Tripleaxel(), new Uproar(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Circlethrow(), new Copycat(), new Cosmicpower(), new Doublehit(), new Encore(), new Fakeout(), new Faketears(), new Firepunch(), new Flail(), new Icepunch(), new Lowkick(), new Poweruppunch(), new Sweetkiss(), new Switcheroo(), new Teeterdance(), new Thunderpunch() };
		public override int Weight => 55;
		public override int ExpYield => 70;
		public override int CatchRate => 190;
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