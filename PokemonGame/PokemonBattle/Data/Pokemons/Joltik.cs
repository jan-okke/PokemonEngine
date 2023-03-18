using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Joltik : Pokemon
	{
		public override string Name => "Joltik";
		public override List<Ability> AvailableAbilities => new() {new Compoundeyes(), new Unnerve() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swarm() };
		public override Stats BaseStats => new Stats(50, 47, 50, 65, 57, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
