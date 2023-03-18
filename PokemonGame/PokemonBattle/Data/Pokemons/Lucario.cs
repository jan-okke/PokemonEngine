using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lucario : Pokemon
	{
		public override string Name => "Lucario";
		public override List<Ability> AvailableAbilities => new() {new Steadfast(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Justified() };
		public override Stats BaseStats => new Stats(70, 110, 70, 90, 115, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Aurasphere() },
			[1] = new List<Move>() { new Aurasphere(), new Lifedew(), new Workup(), new Rocksmash(), new Nastyplot(), new Screech(), new Forcepalm(), new Helpinghand(), new Copycat(), new Finalgambit(), new Reversal(), new Quickattack(), new Detect(), new Feint(), new Metalclaw() },
			[12] = new List<Move>() { new Counter() },
			[16] = new List<Move>() { new Laserfocus() },
			[20] = new List<Move>() { new Poweruppunch() },
			[24] = new List<Move>() { new Calmmind() },
			[28] = new List<Move>() { new Metalsound() },
			[32] = new List<Move>() { new Quickguard() },
			[36] = new List<Move>() { new Bonerush() },
			[40] = new List<Move>() { new Swordsdance() },
			[44] = new List<Move>() { new Healpulse() },
			[48] = new List<Move>() { new Meteormash() },
			[52] = new List<Move>() { new Dragonpulse() },
			[56] = new List<Move>() { new Extremespeed() },
			[60] = new List<Move>() { new Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Aurasphere(), new Blazekick(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Calmmind(), new Closecombat(), new Coaching(), new Crunch(), new Darkpulse(), new Dig(), new Doubleteam(), new Dragonpulse(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Fling(), new Focusblast(), new Focusenergy(), new Focuspunch(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irondefense(), new Irontail(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Poisonjab(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Roar(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Scaryface(), new Screech(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelbeam(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Terrainpulse(), new Thunderpunch(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override int Weight => 540;
		public override int ExpYield => 184;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}