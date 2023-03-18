using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Goomy : Pokemon
	{
		public override string Name => "Goomy";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gooey() };
		public override Stats BaseStats => new Stats(45, 50, 35, 40, 55, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
