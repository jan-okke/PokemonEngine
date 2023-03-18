using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Teddiursa : Pokemon
	{
		public override string Name => "Teddiursa";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Quickfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Honeygather() };
		public override Stats BaseStats => new Stats(60, 80, 50, 40, 50, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
