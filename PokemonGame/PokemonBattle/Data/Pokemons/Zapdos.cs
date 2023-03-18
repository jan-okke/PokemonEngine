using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zapdos : Pokemon
	{
		public override string Name => "Zapdos";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Static() };
		public override Stats BaseStats => new Stats(90, 90, 85, 100, 125, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Thunderwave() },
			[5] = new List<Move>() { new Thundershock() },
			[10] = new List<Move>() { new Lightscreen() },
			[15] = new List<Move>() { new Pluck() },
			[20] = new List<Move>() { new Agility() },
			[25] = new List<Move>() { new Ancientpower() },
			[30] = new List<Move>() { new Charge() },
			[35] = new List<Move>() { new Drillpeck() },
			[40] = new List<Move>() { new Roost() },
			[45] = new List<Move>() { new Discharge() },
			[50] = new List<Move>() { new Raindance() },
			[55] = new List<Move>() { new Thunder() },
			[60] = new List<Move>() { new Detect() },
			[65] = new List<Move>() { new Magneticflux() },
			[70] = new List<Move>() { new Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Batonpass(), new Bravebird(), new Chargebeam(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Eerieimpulse(), new Endure(), new Facade(), new Flash(), new Fly(), new Gigaimpact(), new Hail(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Lightscreen(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Risingvoltage(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Sandstorm(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Uturn(), new Voltswitch(), new Weatherball(), new Wildcharge() };
		public override int Weight => 526;
		public override int ExpYield => 290;
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