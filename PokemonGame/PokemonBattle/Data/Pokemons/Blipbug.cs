using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Blipbug : Pokemon
	{
		public override string Name => "Blipbug";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Compoundeyes() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
		public override Stats BaseStats => new Stats(25, 20, 20, 25, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Strugglebug() },
		};
		public override List<Move> EggMoves => new List<Move>() { new Moves.Infestation(), new Moves.Recover(), new Moves.Stickyweb(), new Moves.Supersonic() };
		public override int Weight => 80;
		public override int ExpYield => 36;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}