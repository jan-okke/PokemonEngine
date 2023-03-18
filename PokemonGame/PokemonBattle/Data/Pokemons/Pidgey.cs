using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pidgey : Pokemon
	{
		public override string Name => "Pidgey";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Tangledfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bigpecks() };
		public override Stats BaseStats => new Stats(40, 45, 40, 35, 35, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[5] = new List<Move>() { new Sandattack() },
			[9] = new List<Move>() { new Gust() },
			[13] = new List<Move>() { new Quickattack() },
			[17] = new List<Move>() { new Whirlwind() },
			[21] = new List<Move>() { new Twister() },
			[25] = new List<Move>() { new Featherdance() },
			[29] = new List<Move>() { new Agility() },
			[33] = new List<Move>() { new Wingattack() },
			[37] = new List<Move>() { new Roost() },
			[41] = new List<Move>() { new Tailwind() },
			[45] = new List<Move>() { new Aerialace() },
			[49] = new List<Move>() { new Airslash() },
			[53] = new List<Move>() { new Hurricane() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Endure(), new Facade(), new Fly(), new Frustration(), new Heatwave(), new Hiddenpower(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aircutter(), new Airslash(), new Bravebird(), new Uproar() };
		public override int Weight => 18;
		public override int ExpYield => 50;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}