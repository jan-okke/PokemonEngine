using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Suicune : Pokemon
	{
		public override string Name => "Suicune";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Innerfocus() };
		public override Stats BaseStats => new Stats(100, 75, 115, 90, 115, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sheercold(), new Extremespeed(), new Watergun(), new Leer(), new Gust(), new Mist() },
			[6] = new List<Move>() { new Waterpulse() },
			[12] = new List<Move>() { new Bite() },
			[18] = new List<Move>() { new Calmmind() },
			[24] = new List<Move>() { new Roar() },
			[30] = new List<Move>() { new Icefang() },
			[36] = new List<Move>() { new Tailwind() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Extrasensory() },
			[54] = new List<Move>() { new Surf() },
			[60] = new List<Move>() { new Mirrorcoat() },
			[66] = new List<Move>() { new Raindance() },
			[72] = new List<Move>() { new Hydropump() },
			[78] = new List<Move>() { new Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Airslash(), new Avalanche(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Calmmind(), new Crunch(), new Cut(), new Dig(), new Dive(), new Doubleteam(), new Endure(), new Facade(), new Gigaimpact(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Icywind(), new Ironhead(), new Irontail(), new Liquidation(), new Protect(), new Psychup(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rockclimb(), new Rocksmash(), new Round(), new Sandstorm(), new Scald(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool() };
		public override int Weight => 1870;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}