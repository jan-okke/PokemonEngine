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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Innerfocus() };
		public override Stats BaseStats => new Stats(100, 75, 115, 90, 115, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sheercold(), new Moves.Extremespeed(), new Moves.Watergun(), new Moves.Leer(), new Moves.Gust(), new Moves.Mist() },
			[6] = new List<Move>() { new Moves.Waterpulse() },
			[12] = new List<Move>() { new Moves.Bite() },
			[18] = new List<Move>() { new Moves.Calmmind() },
			[24] = new List<Move>() { new Moves.Roar() },
			[30] = new List<Move>() { new Moves.Icefang() },
			[36] = new List<Move>() { new Moves.Tailwind() },
			[42] = new List<Move>() { new Moves.Crunch() },
			[48] = new List<Move>() { new Moves.Extrasensory() },
			[54] = new List<Move>() { new Moves.Surf() },
			[60] = new List<Move>() { new Moves.Mirrorcoat() },
			[66] = new List<Move>() { new Moves.Raindance() },
			[72] = new List<Move>() { new Moves.Hydropump() },
			[78] = new List<Move>() { new Moves.Blizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Airslash(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool() };
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