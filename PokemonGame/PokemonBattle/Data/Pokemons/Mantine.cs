using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mantine : Pokemon
	{
		public override string Name => "Mantine";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(85, 40, 70, 70, 80, 140);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Psybeam(), new Bulletseed(), new Roost(), new Tackle(), new Watergun(), new Supersonic(), new Wingattack() },
			[12] = new List<Move>() { new Waterpulse() },
			[16] = new List<Move>() { new Wideguard() },
			[20] = new List<Move>() { new Agility() },
			[24] = new List<Move>() { new Bubblebeam() },
			[28] = new List<Move>() { new Headbutt() },
			[32] = new List<Move>() { new Airslash() },
			[36] = new List<Move>() { new Aquaring() },
			[40] = new List<Move>() { new Bounce() },
			[44] = new List<Move>() { new Takedown() },
			[48] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Amnesia(), new Assurance(), new Attract(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bounce(), new Brine(), new Bulldoze(), new Bulletseed(), new Defog(), new Dive(), new Doubleteam(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Gunkshot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Ironhead(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Roost(), new Round(), new Scald(), new Seedbomb(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Confuseray(), new Haze(), new Hydropump(), new Mirrorcoat(), new Slam(), new Splash(), new Tailwind(), new Twister(), new Wideguard() };
		public override int Weight => 2200;
		public override int ExpYield => 170;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}