using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Starly : Pokemon
	{
		public override string Name => "Starly";
		public override List<Ability> AvailableAbilities => new() {new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Reckless() };
		public override Stats BaseStats => new Stats(40, 55, 30, 60, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[5] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Wingattack() },
			[13] = new List<Move>() { new Doubleteam() },
			[17] = new List<Move>() { new Endeavor() },
			[21] = new List<Move>() { new Whirlwind() },
			[25] = new List<Move>() { new Aerialace() },
			[29] = new List<Move>() { new Takedown() },
			[33] = new List<Move>() { new Agility() },
			[37] = new List<Move>() { new Bravebird() },
			[41] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Fly(), new Frustration(), new Heatwave(), new Hiddenpower(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Detect(), new Doubleedge(), new Featherdance(), new Furyattack(), new Revenge(), new Sandattack(), new Uproar() };
		public override int Weight => 20;
		public override int ExpYield => 49;
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