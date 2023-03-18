using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dracovish : Pokemon
	{
		public override string Name => "Dracovish";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sandrush() };
		public override Stats BaseStats => new Stats(90, 90, 100, 75, 70, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Dragon };
