using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Mantyke : Pokemon
	{
		public override string Name => "Mantyke";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Waterveil() };
		public override Stats BaseStats => new Stats(45, 20, 50, 60, 120, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Watergun() },
			[4] = new List<Move>() { new Supersonic() },
			[8] = new List<Move>() { new Wingattack() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Amnesia(), new Attract(), new Blizzard(), new Bounce(), new Bulldoze(), new Dive(), new Doubleteam(), new Earthquake(), new Endure(), new Facade(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Confuseray(), new Haze(), new Hydropump(), new Mirrorcoat(), new Slam(), new Splash(), new Tailwind(), new Twister(), new Wideguard() };
		public override int Weight => 650;
		public override int ExpYield => 69;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}