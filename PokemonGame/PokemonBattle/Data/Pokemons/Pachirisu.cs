using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pachirisu : Pokemon
	{
		public override string Name => "Pachirisu";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Voltabsorb() };
		public override Stats BaseStats => new Stats(60, 45, 70, 95, 45, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
