using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Goldeen : Pokemon
	{
		public override string Name => "Goldeen";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Waterveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(45, 67, 60, 35, 50, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Tailwhip() },
			[5] = new List<Move>() { new Supersonic() },
			[10] = new List<Move>() { new Waterpulse() },
			[15] = new List<Move>() { new Hornattack() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Aquaring() },
			[30] = new List<Move>() { new Flail() },
			[35] = new List<Move>() { new Waterfall() },
			[40] = new List<Move>() { new Soak() },
			[45] = new List<Move>() { new Megahorn() },
			[50] = new List<Move>() { new Horndrill() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Dive(), new Doubleteam(), new Drillrun(), new Endure(), new Facade(), new Flipturn(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Megahorn(), new Muddywater(), new Mudshot(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Throatchop(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Acupressure(), new Aquatail(), new Bodyslam(), new Haze(), new Hydropump(), new Mudshot(), new Mudslap(), new Psybeam(), new Skullbash() };
		public override int Weight => 150;
		public override int ExpYield => 64;
		public override int CatchRate => 225;
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