using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tyrantrum : Pokemon
	{
		public override string Name => "Tyrantrum";
		public override List<Ability> AvailableAbilities => new() {new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rockhead() };
		public override Stats BaseStats => new Stats(82, 121, 119, 71, 69, 59);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Dragon };
