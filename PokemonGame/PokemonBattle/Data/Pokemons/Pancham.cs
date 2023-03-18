using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pancham : Pokemon
	{
		public override string Name => "Pancham";
		public override List<Ability> AvailableAbilities => new() {new Ironfist(), new Moldbreaker() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(67, 82, 62, 43, 46, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Armthrust() },
			[8] = new List<Move>() { new Taunt() },
			[12] = new List<Move>() { new Circlethrow() },
			[16] = new List<Move>() { new Lowsweep() },
			[20] = new List<Move>() { new Workup() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Vitalthrow() },
			[33] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Bodyslam() },
			[40] = new List<Move>() { new Partingshot() },
			[44] = new List<Move>() { new Entrainment() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Brickbreak(), new Bulkup(), new Bulldoze(), new Coaching(), new Crunch(), new Darkpulse(), new Dig(), new Drainpunch(), new Endure(), new Facade(), new Falseswipe(), new Firepunch(), new Fling(), new Foulplay(), new Grassknot(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icepunch(), new Ironhead(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Rockslide(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Superpower(), new Surf(), new Swordsdance(), new Taunt(), new Thunderpunch(), new Uproar(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Powertrip(), new Quash(), new Quickguard(), new Seismictoss(), new Stormthrow() };
		public override int Weight => 80;
		public override int ExpYield => 70;
		public override int CatchRate => 220;
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