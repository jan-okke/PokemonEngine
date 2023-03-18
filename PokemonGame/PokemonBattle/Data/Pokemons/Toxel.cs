using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Toxel : Pokemon
	{
		public override string Name => "Toxel";
		public override List<Ability> AvailableAbilities => new() {new Rattled(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Klutz() };
		public override Stats BaseStats => new Stats(40, 38, 35, 54, 35, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Belch(), new Tearfullook(), new Nuzzle(), new Growl(), new Flail(), new Acid() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Encore(), new Endure(), new Facade(), new Hiddenpower(), new Protect(), new Rest(), new Round(), new Sleeptalk(), new Snore(), new Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Endeavor(), new Metalsound(), new Poweruppunch() };
		public override int Weight => 110;
		public override int ExpYield => 48;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}