using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seaking : Pokemon
	{
		public override string Name => "Seaking";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Waterveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(80, 92, 65, 65, 80, 68);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Tailwhip(), new Supersonic(), new Waterpulse() },
			[15] = new List<Move>() { new Hornattack() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Aquaring() },
			[30] = new List<Move>() { new Flail() },
			[37] = new List<Move>() { new Waterfall() },
			[44] = new List<Move>() { new Soak() },
			[51] = new List<Move>() { new Megahorn() },
			[58] = new List<Move>() { new Horndrill() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Blizzard(), new Bodyslam(), new Bounce(), new Dive(), new Doubleteam(), new Drillrun(), new Endure(), new Facade(), new Flipturn(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Megahorn(), new Muddywater(), new Mudshot(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Sleeptalk(), new Smartstrike(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Throatchop(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 390;
		public override int ExpYield => 158;
		public override int CatchRate => 60;
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