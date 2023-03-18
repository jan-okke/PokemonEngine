using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toxicroak : Pokemon
	{
		public override string Name => "Toxicroak";
		public override List<Ability> AvailableAbilities => new() {new Anticipation(), new Dryskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisontouch() };
		public override Stats BaseStats => new Stats(83, 106, 65, 86, 65, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisonsting(), new Mudslap(), new Astonish(), new Taunt() },
			[12] = new List<Move>() { new Flatter() },
			[16] = new List<Move>() { new Revenge() },
			[20] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Suckerpunch() },
			[28] = new List<Move>() { new Swagger() },
			[32] = new List<Move>() { new Poisonjab() },
			[36] = new List<Move>() { new Toxic() },
			[42] = new List<Move>() { new Nastyplot() },
			[48] = new List<Move>() { new Sludgebomb() },
			[54] = new List<Move>() { new Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Batonpass(), new Bounce(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Coaching(), new Corrosivegas(), new Crosspoison(), new Cut(), new Darkpulse(), new Dig(), new Doubleteam(), new Drainpunch(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Gigaimpact(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Icywind(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Nastyplot(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Screech(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Torment(), new Toxic(), new Venomdrench(), new Venoshock(), new Workup(), new Xscissor() };
		public override int Weight => 444;
		public override int ExpYield => 172;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}