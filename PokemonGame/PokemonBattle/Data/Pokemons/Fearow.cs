using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fearow : Pokemon
	{
		public override string Name => "Fearow";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sniper() };
		public override Stats BaseStats => new Stats(65, 90, 65, 61, 61, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Drillrun(), new Moves.Pluck(), new Moves.Peck(), new Moves.Growl(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Leer() },
			[8] = new List<Move>() { new Moves.Assurance() },
			[11] = new List<Move>() { new Moves.Furyattack() },
			[15] = new List<Move>() { new Moves.Aerialace() },
			[18] = new List<Move>() { new Moves.Wingattack() },
			[23] = new List<Move>() { new Moves.Takedown() },
			[27] = new List<Move>() { new Moves.Agility() },
			[32] = new List<Move>() { new Moves.Focusenergy() },
			[36] = new List<Move>() { new Moves.Roost() },
			[41] = new List<Move>() { new Moves.Drillpeck() },
			[45] = new List<Move>() { new Moves.Drillrun() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Confide(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drillrun(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fly(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Laserfocus(), new Moves.Pluck(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Roost(), new Moves.Round(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Tailwind(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
		public override int Weight => 380;
		public override int ExpYield => 155;
		public override int CatchRate => 90;
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