using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Weezing : Pokemon
	{
		public override string Name => "Weezing";
		public override List<Ability> AvailableAbilities => new() {new Levitate(), new Neutralizinggas() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stench() };
		public override Stats BaseStats => new Stats(65, 90, 120, 60, 85, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
