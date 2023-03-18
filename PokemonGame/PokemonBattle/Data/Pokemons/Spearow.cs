using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spearow : Pokemon
	{
		public override string Name => "Spearow";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
		public override Stats BaseStats => new Stats(40, 60, 30, 31, 31, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Peck(), new Moves.Growl() },
			[4] = new List<Move>() { new Moves.Leer() },
			[8] = new List<Move>() { new Moves.Assurance() },
			[11] = new List<Move>() { new Moves.Furyattack() },
			[15] = new List<Move>() { new Moves.Aerialace() },
			[18] = new List<Move>() { new Moves.Wingattack() },
			[22] = new List<Move>() { new Moves.Takedown() },
			[25] = new List<Move>() { new Moves.Agility() },
			[29] = new List<Move>() { new Moves.Focusenergy() },
			[32] = new List<Move>() { new Moves.Roost() },
			[36] = new List<Move>() { new Moves.Drillpeck() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fly(), new Moves.Frustration(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Featherdance(), new Moves.Quickattack(), new Moves.Scaryface(), new Moves.Skyattack(), new Moves.Triattack(), new Moves.Uproar(), new Moves.Whirlwind() };
		public override int Weight => 20;
		public override int ExpYield => 52;
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