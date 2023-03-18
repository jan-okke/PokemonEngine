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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Reckless() };
		public override Stats BaseStats => new Stats(40, 55, 30, 30, 30, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
			[5] = new List<Move>() { new Moves.Quickattack() },
			[9] = new List<Move>() { new Moves.Wingattack() },
			[13] = new List<Move>() { new Moves.Doubleteam() },
			[17] = new List<Move>() { new Moves.Endeavor() },
			[21] = new List<Move>() { new Moves.Whirlwind() },
			[25] = new List<Move>() { new Moves.Aerialace() },
			[29] = new List<Move>() { new Moves.Takedown() },
			[33] = new List<Move>() { new Moves.Agility() },
			[37] = new List<Move>() { new Moves.Bravebird() },
			[41] = new List<Move>() { new Moves.Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Detect(), new Moves.Doubleedge(), new Moves.Featherdance(), new Moves.Furyattack(), new Moves.Revenge(), new Moves.Sandattack(), new Moves.Uproar() };
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