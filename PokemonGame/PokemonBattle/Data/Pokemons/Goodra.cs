using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Goodra : Pokemon
	{
		public override string Name => "Goodra";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gooey() };
		public override Stats BaseStats => new Stats(90, 100, 70, 80, 110, 150);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
