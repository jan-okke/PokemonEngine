using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Staravia : Pokemon
	{
		public override string Name => "Staravia";
		public override List<Ability> AvailableAbilities => new() {new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(55, 75, 50, 80, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Quickattack() },
			[5] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Wingattack() },
			[13] = new List<Move>() { new Doubleteam() },
			[18] = new List<Move>() { new Endeavor() },
			[23] = new List<Move>() { new Whirlwind() },
			[28] = new List<Move>() { new Aerialace() },
			[33] = new List<Move>() { new Takedown() },
			[38] = new List<Move>() { new Agility() },
			[43] = new List<Move>() { new Bravebird() },
			[48] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Heatwave(), new Hiddenpower(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 155;
		public override int ExpYield => 119;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}