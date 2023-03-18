using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Croagunk : Pokemon
	{
		public override string Name => "Croagunk";
		public override List<Ability> AvailableAbilities => new() {new Anticipation(), new Dryskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisontouch() };
		public override Stats BaseStats => new Stats(48, 61, 40, 61, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Mudslap() },
			[4] = new List<Move>() { new Astonish() },
			[8] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Flatter() },
			[16] = new List<Move>() { new Revenge() },
			[20] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Swagger() },
			[32] = new List<Move>() { new Poisonjab() },
			[36] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Nastyplot() },
			[44] = new List<Move>() { new Sludgebomb() },
			[48] = new List<Move>() { new Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Coaching(), new Darkpulse(), new Dig(), new Doubleteam(), new Drainpunch(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Icywind(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Toxic(), new Venomdrench(), new Venoshock(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Bulletpunch(), new Counter(), new Crosschop(), new Dynamicpunch(), new Fakeout(), new Feint(), new Headbutt(), new Quickguard(), new Vacuumwave() };
		public override int Weight => 230;
		public override int ExpYield => 60;
		public override int CatchRate => 140;
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