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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Static() };
		public override Stats BaseStats => new Stats(90, 90, 85, 125, 90, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Thunderwave() },
			[5] = new List<Move>() { new Moves.Thundershock() },
			[10] = new List<Move>() { new Moves.Lightscreen() },
			[15] = new List<Move>() { new Moves.Pluck() },
			[20] = new List<Move>() { new Moves.Agility() },
			[25] = new List<Move>() { new Moves.Ancientpower() },
			[30] = new List<Move>() { new Moves.Charge() },
			[35] = new List<Move>() { new Moves.Drillpeck() },
			[40] = new List<Move>() { new Moves.Roost() },
			[45] = new List<Move>() { new Moves.Discharge() },
			[50] = new List<Move>() { new Moves.Raindance() },
			[55] = new List<Move>() { new Moves.Thunder() },
			[60] = new List<Move>() { new Moves.Detect() },
			[65] = new List<Move>() { new Moves.Magneticflux() },
			[70] = new List<Move>() { new Moves.Zapcannon() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Batonpass(), new Moves.Bravebird(), new Moves.Chargebeam(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Eerieimpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Risingvoltage(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Uturn(), new Moves.Voltswitch(), new Moves.Weatherball(), new Moves.Wildcharge() };
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