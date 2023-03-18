using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gyarados : Pokemon
	{
		public override string Name => "Gyarados";
		public override List<Ability> AvailableAbilities => new() {new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(95, 125, 79, 81, 60, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bite() },
			[1] = new List<Move>() { new Bite(), new Flail(), new Splash(), new Tackle(), new Leer(), new Twister() },
			[4] = new List<Move>() { new Whirlpool() },
			[8] = new List<Move>() { new Icefang() },
			[12] = new List<Move>() { new Brine() },
			[16] = new List<Move>() { new Scaryface() },
			[21] = new List<Move>() { new Waterfall() },
			[24] = new List<Move>() { new Crunch() },
			[28] = new List<Move>() { new Raindance() },
			[32] = new List<Move>() { new Aquatail() },
			[36] = new List<Move>() { new Dragondance() },
			[40] = new List<Move>() { new Hydropump() },
			[44] = new List<Move>() { new Hurricane() },
			[48] = new List<Move>() { new Thrash() },
			[52] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodyslam(), new Bounce(), new Brine(), new Brutalswing(), new Bulldoze(), new Crunch(), new Darkpulse(), new Dive(), new Doubleteam(), new Dragondance(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icywind(), new Ironhead(), new Irontail(), new Lashout(), new Muddywater(), new Outrage(), new Payback(), new Powerwhip(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Round(), new Sandstorm(), new Scald(), new Scaleshot(), new Scaryface(), new Sleeptalk(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 2350;
		public override int ExpYield => 189;
		public override int CatchRate => 45;
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