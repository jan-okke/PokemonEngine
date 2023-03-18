using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Yamper : Pokemon
	{
		public override string Name => "Yamper";
		public override List<Ability> AvailableAbilities => new() {new Ballfetch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(59, 45, 50, 26, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip() },
			[5] = new List<Move>() { new Nuzzle() },
			[10] = new List<Move>() { new Bite() },
			[15] = new List<Move>() { new Roar() },
			[20] = new List<Move>() { new Spark() },
			[26] = new List<Move>() { new Charm() },
			[30] = new List<Move>() { new Crunch() },
			[35] = new List<Move>() { new Charge() },
			[40] = new List<Move>() { new Wildcharge() },
			[45] = new List<Move>() { new Playrough() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Crunch(), new Dig(), new Electroball(), new Endure(), new Facade(), new Firefang(), new Helpinghand(), new Hiddenpower(), new Playrough(), new Protect(), new Rest(), new Risingvoltage(), new Round(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override List<Move> EggMoves => new List<Move>() { new Discharge(), new Doubleedge(), new Flamecharge(), new Howl(), new Sandattack() };
		public override int Weight => 135;
		public override int ExpYield => 54;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}