using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golduck : Pokemon
	{
		public override string Name => "Golduck";
		public override List<Ability> AvailableAbilities => new() {new Damp(), new Cloudnine() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(80, 82, 78, 85, 95, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Aquajet(), new Scratch(), new Tailwhip(), new Watergun(), new Confusion() },
			[9] = new List<Move>() { new Furyswipes() },
			[12] = new List<Move>() { new Waterpulse() },
			[15] = new List<Move>() { new Disable() },
			[18] = new List<Move>() { new Zenheadbutt() },
			[21] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Aquatail() },
			[27] = new List<Move>() { new Soak() },
			[30] = new List<Move>() { new Psychup() },
			[36] = new List<Move>() { new Amnesia() },
			[40] = new List<Move>() { new Hydropump() },
			[45] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Calmmind(), new Dig(), new Dive(), new Doubleteam(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Flipturn(), new Focusblast(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Liquidation(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Muddywater(), new Payday(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Rest(), new Rockclimb(), new Rocksmash(), new Round(), new Scald(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 766;
		public override int ExpYield => 175;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}