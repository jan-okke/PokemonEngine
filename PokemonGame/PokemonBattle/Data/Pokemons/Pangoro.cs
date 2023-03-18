using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pangoro : Pokemon
	{
		public override string Name => "Pangoro";
		public override List<Ability> AvailableAbilities => new() {new Ironfist(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(95, 124, 78, 58, 69, 71);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Nightslash() },
			[1] = new List<Move>() { new Nightslash(), new Bulletpunch(), new Tackle(), new Leer(), new Armthrust(), new Taunt() },
			[12] = new List<Move>() { new Circlethrow() },
			[16] = new List<Move>() { new Lowsweep() },
			[20] = new List<Move>() { new Workup() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Vitalthrow() },
			[35] = new List<Move>() { new Crunch() },
			[40] = new List<Move>() { new Bodyslam() },
			[46] = new List<Move>() { new Partingshot() },
			[52] = new List<Move>() { new Entrainment() },
			[58] = new List<Move>() { new Hammerarm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Closecombat(), new Coaching(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Dig(), new Dragonclaw(), new Drainpunch(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Focusblast(), new Focusenergy(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Ironhead(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Reversal(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Uproar(), new Workup(), new Xscissor(), new Zenheadbutt() };
		public override int Weight => 1360;
		public override int ExpYield => 173;
		public override int CatchRate => 65;
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