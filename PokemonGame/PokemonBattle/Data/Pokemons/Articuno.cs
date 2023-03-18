using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Articuno : Pokemon
	{
		public override string Name => "Articuno";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Snowcloak() };
		public override Stats BaseStats => new Stats(90, 85, 100, 95, 125, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Mist() },
			[5] = new List<Move>() { new Powdersnow() },
			[10] = new List<Move>() { new Reflect() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Ancientpower() },
			[30] = new List<Move>() { new Tailwind() },
			[35] = new List<Move>() { new Freezedry() },
			[40] = new List<Move>() { new Roost() },
			[45] = new List<Move>() { new Icebeam() },
			[50] = new List<Move>() { new Hail() },
			[55] = new List<Move>() { new Hurricane() },
			[60] = new List<Move>() { new Mindreader() },
			[65] = new List<Move>() { new Blizzard() },
			[70] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Avalanche(), new Blizzard(), new Bravebird(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Fly(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Icebeam(), new Iciclespear(), new Icywind(), new Pluck(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Sandstorm(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Tripleaxel(), new Uturn(), new Waterpulse(), new Weatherball() };
		public override int Weight => 554;
		public override int ExpYield => 290;
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