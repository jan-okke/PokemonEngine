using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pincurchin : Pokemon
	{
		public override string Name => "Pincurchin";
		public override List<Ability> AvailableAbilities => new() {new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Electricsurge() };
		public override Stats BaseStats => new Stats(48, 101, 95, 15, 91, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
