using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wobbuffet : Pokemon
	{
		public override string Name => "Wobbuffet";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shadowtag() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
		public override Stats BaseStats => new Stats(190, 33, 58, 33, 58, 33);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Counter(), new Moves.Mirrorcoat(), new Moves.Safeguard(), new Moves.Destinybond() },
			[1] = new List<Move>() { new Moves.Splash(), new Moves.Charm(), new Moves.Encore(), new Moves.Amnesia(), new Moves.Counter(), new Moves.Mirrorcoat(), new Moves.Safeguard(), new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Charm(), new Moves.Encore(), new Moves.Safeguard() };
		public override int Weight => 285;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}