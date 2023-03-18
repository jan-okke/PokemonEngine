using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lugia : Pokemon
	{
		public override string Name => "Lugia";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Multiscale() };
		public override Stats BaseStats => new Stats(106, 90, 130, 110, 90, 154);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Dragonrush(), new Gust(), new Whirlwind(), new Weatherball(), new Ancientpower() },
			[9] = new List<Move>() { new Mist() },
			[18] = new List<Move>() { new Safeguard() },
			[27] = new List<Move>() { new Calmmind() },
			[36] = new List<Move>() { new Extrasensory() },
			[45] = new List<Move>() { new Recover() },
			[54] = new List<Move>() { new Aeroblast() },
			[63] = new List<Move>() { new Raindance() },
			[72] = new List<Move>() { new Hydropump() },
			[81] = new List<Move>() { new Futuresight() },
			[90] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Defog(), new Dive(), new Doubleteam(), new Dragonpulse(), new Dreameater(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Flash(), new Fly(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icywind(), new Imprison(), new Ironhead(), new Irontail(), new Lightscreen(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Scaleshot(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Steelwing(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Trick(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 2160;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}