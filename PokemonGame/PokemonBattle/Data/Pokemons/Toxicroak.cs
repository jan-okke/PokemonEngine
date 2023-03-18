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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Anticipation(), new Abilities.Dryskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Poisontouch() };
		public override Stats BaseStats => new Stats(83, 106, 65, 86, 65, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Poisonsting(), new Moves.Mudslap(), new Moves.Astonish(), new Moves.Taunt() },
			[12] = new List<Move>() { new Moves.Flatter() },
			[16] = new List<Move>() { new Moves.Revenge() },
			[20] = new List<Move>() { new Moves.Venoshock() },
			[24] = new List<Move>() { new Moves.Suckerpunch() },
			[28] = new List<Move>() { new Moves.Swagger() },
			[32] = new List<Move>() { new Moves.Poisonjab() },
			[36] = new List<Move>() { new Moves.Toxic() },
			[42] = new List<Move>() { new Moves.Nastyplot() },
			[48] = new List<Move>() { new Moves.Sludgebomb() },
			[54] = new List<Move>() { new Moves.Belch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Coaching(), new Moves.Corrosivegas(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Screech(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Toxic(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Workup(), new Moves.Xscissor() };
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