using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kyogre : Pokemon
	{
		public override string Name => "Kyogre";
		public override List<Ability> AvailableAbilities => new() {new Drizzle() };
		public override Stats BaseStats => new Stats(100, 100, 90, 150, 140, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Waterpulse(), new Ancientpower(), new Bodyslam(), new Scaryface() },
			[9] = new List<Move>() { new Aquatail() },
			[18] = new List<Move>() { new Calmmind() },
			[27] = new List<Move>() { new Muddywater() },
			[36] = new List<Move>() { new Icebeam() },
			[45] = new List<Move>() { new Sheercold() },
			[54] = new List<Move>() { new Aquaring() },
			[63] = new List<Move>() { new Originpulse() },
			[72] = new List<Move>() { new Hydropump() },
			[81] = new List<Move>() { new Doubleedge() },
			[90] = new List<Move>() { new Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Avalanche(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Bulldoze(), new Calmmind(), new Dive(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Heavyslam(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Ironhead(), new Liquidation(), new Muddywater(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Scald(), new Scaryface(), new Shockwave(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 3520;
		public override int ExpYield => 335;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}