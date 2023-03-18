using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clawitzer : Pokemon
	{
		public override string Name => "Clawitzer";
		public override List<Ability> AvailableAbilities => new() {new Megalauncher() };
		public override Stats BaseStats => new Stats(71, 73, 88, 59, 120, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
