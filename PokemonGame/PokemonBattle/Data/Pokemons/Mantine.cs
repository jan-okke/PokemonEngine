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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Waterveil() };
		public override Stats BaseStats => new Stats(85, 40, 70, 80, 140, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Psybeam(), new Moves.Bulletseed(), new Moves.Roost(), new Moves.Tackle(), new Moves.Watergun(), new Moves.Supersonic(), new Moves.Wingattack() },
			[12] = new List<Move>() { new Moves.Waterpulse() },
			[16] = new List<Move>() { new Moves.Wideguard() },
			[20] = new List<Move>() { new Moves.Agility() },
			[24] = new List<Move>() { new Moves.Bubblebeam() },
			[28] = new List<Move>() { new Moves.Headbutt() },
			[32] = new List<Move>() { new Moves.Airslash() },
			[36] = new List<Move>() { new Moves.Aquaring() },
			[40] = new List<Move>() { new Moves.Bounce() },
			[44] = new List<Move>() { new Moves.Takedown() },
			[48] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Scald(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Confuseray(), new Moves.Haze(), new Moves.Hydropump(), new Moves.Mirrorcoat(), new Moves.Slam(), new Moves.Splash(), new Moves.Tailwind(), new Moves.Twister(), new Moves.Wideguard() };
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