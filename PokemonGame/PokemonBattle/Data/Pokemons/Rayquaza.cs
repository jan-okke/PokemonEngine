using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rayquaza : Pokemon
	{
		public override string Name => "Rayquaza";
		public override List<Ability> AvailableAbilities => new() {new Airlock() };
		public override Stats BaseStats => new Stats(105, 150, 90, 95, 150, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonascent(), new Twister(), new Ancientpower(), new Airslash(), new Scaryface() },
			[9] = new List<Move>() { new Crunch() },
			[18] = new List<Move>() { new Dragondance() },
			[27] = new List<Move>() { new Extremespeed() },
			[36] = new List<Move>() { new Dragonpulse() },
			[45] = new List<Move>() { new Hypervoice() },
			[54] = new List<Move>() { new Rest() },
			[63] = new List<Move>() { new Fly() },
			[72] = new List<Move>() { new Hurricane() },
			[81] = new List<Move>() { new Outrage() },
			[90] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Avalanche(), new Blizzard(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Cosmicpower(), new Crunch(), new Dive(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Fling(), new Fly(), new Focusblast(), new Gigaimpact(), new Gyroball(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Ironhead(), new Irontail(), new Meteorbeam(), new Outrage(), new Overheat(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scaleshot(), new Scaryface(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Swordsdance(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uproar(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 2065;
		public override int ExpYield => 340;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}