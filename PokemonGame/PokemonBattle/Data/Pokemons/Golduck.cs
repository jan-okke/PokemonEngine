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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Damp(), new Abilities.Cloudnine() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Swiftswim() };
		public override Stats BaseStats => new Stats(80, 82, 78, 95, 80, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Aquajet(), new Moves.Scratch(), new Moves.Tailwhip(), new Moves.Watergun(), new Moves.Confusion() },
			[9] = new List<Move>() { new Moves.Furyswipes() },
			[12] = new List<Move>() { new Moves.Waterpulse() },
			[15] = new List<Move>() { new Moves.Disable() },
			[18] = new List<Move>() { new Moves.Zenheadbutt() },
			[21] = new List<Move>() { new Moves.Screech() },
			[24] = new List<Move>() { new Moves.Aquatail() },
			[27] = new List<Move>() { new Moves.Soak() },
			[30] = new List<Move>() { new Moves.Psychup() },
			[36] = new List<Move>() { new Moves.Amnesia() },
			[40] = new List<Move>() { new Moves.Hydropump() },
			[45] = new List<Move>() { new Moves.Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brine(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Flipturn(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Muddywater(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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