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
		public override List<Ability> AvailableAbilities => new() {new Keeneye() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sniper() };
		public override Stats BaseStats => new Stats(65, 90, 65, 100, 61, 61);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Drillrun(), new Pluck(), new Peck(), new Growl(), new Leer() },
			[4] = new List<Move>() { new Leer() },
			[8] = new List<Move>() { new Assurance() },
			[11] = new List<Move>() { new Furyattack() },
			[15] = new List<Move>() { new Aerialace() },
			[18] = new List<Move>() { new Wingattack() },
			[23] = new List<Move>() { new Takedown() },
			[27] = new List<Move>() { new Agility() },
			[32] = new List<Move>() { new Focusenergy() },
			[36] = new List<Move>() { new Roost() },
			[41] = new List<Move>() { new Drillpeck() },
			[45] = new List<Move>() { new Drillrun() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Drillrun(), new Echoedvoice(), new Endure(), new Facade(), new Falseswipe(), new Fly(), new Frustration(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Throatchop(), new Uproar(), new Uturn(), new Workup() };
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