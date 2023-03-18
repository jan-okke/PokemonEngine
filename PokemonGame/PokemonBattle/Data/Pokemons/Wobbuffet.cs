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
		public override List<Ability> AvailableAbilities => new() {new Shadowtag() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(190, 33, 58, 33, 58, 33);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Counter(), new Mirrorcoat(), new Safeguard(), new Destinybond() },
			[1] = new List<Move>() { new Splash(), new Charm(), new Encore(), new Amnesia(), new Counter(), new Mirrorcoat(), new Safeguard(), new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Charm(), new Encore(), new Safeguard() };
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