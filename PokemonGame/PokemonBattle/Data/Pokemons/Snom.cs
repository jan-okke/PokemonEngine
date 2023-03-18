using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Snom : Pokemon
	{
		public override string Name => "Snom";
		public override List<Ability> AvailableAbilities => new() {new Shielddust() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icescales() };
		public override Stats BaseStats => new Stats(30, 25, 35, 20, 45, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Strugglebug() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbuzz(), new Endure(), new Facade(), new Hiddenpower(), new Iciclespear(), new Icywind(), new Protect(), new Rest(), new Round(), new Skittersmack(), new Sleeptalk(), new Snore(), new Substitute() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Fairywind(), new Mirrorcoat() };
		public override int Weight => 38;
		public override int ExpYield => 37;
		public override int CatchRate => 190;
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