using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Staraptor : Pokemon
	{
		public override string Name => "Staraptor";
		public override List<Ability> AvailableAbilities => new() {new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(85, 120, 70, 50, 60, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Closecombat() },
			[1] = new List<Move>() { new Closecombat(), new Tackle(), new Growl(), new Quickattack(), new Wingattack() },
			[5] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Wingattack() },
			[13] = new List<Move>() { new Doubleteam() },
			[18] = new List<Move>() { new Endeavor() },
			[23] = new List<Move>() { new Whirlwind() },
			[28] = new List<Move>() { new Aerialace() },
			[33] = new List<Move>() { new Takedown() },
			[41] = new List<Move>() { new Agility() },
			[49] = new List<Move>() { new Bravebird() },
			[57] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uproar(), new Uturn(), new Workup() };
		public override int Weight => 249;
		public override int ExpYield => 243;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}