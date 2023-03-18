using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Koffing : Pokemon
	{
		public override string Name => "Koffing";
		public override List<Ability> AvailableAbilities => new() {new Levitate(), new Neutralizinggas() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stench() };
		public override Stats BaseStats => new Stats(40, 65, 95, 35, 60, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
