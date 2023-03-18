using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lopunny : Pokemon
	{
		public override string Name => "Lopunny";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Limber() };
		public override Stats BaseStats => new Stats(65, 76, 84, 105, 54, 96);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mirrorcoat(), new Magiccoat(), new Splash(), new Pound(), new Defensecurl(), new Babydolleyes() },
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
			[56] = new List<Move>() { new Highjumpkick() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Assurance(), new Attract(), new Aurasphere(), new Batonpass(), new Blizzard(), new Bounce(), new Brutalswing(), new Chargebeam(), new Charm(), new Closecombat(), new Cosmicpower(), new Cut(), new Dig(), new Doubleteam(), new Drainpunch(), new Encore(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Reversal(), new Rocksmash(), new Round(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Tripleaxel(), new Uproar(), new Uturn(), new Waterpulse(), new Workup() };
		public override int Weight => 333;
		public override int ExpYield => 168;
		public override int CatchRate => 60;
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