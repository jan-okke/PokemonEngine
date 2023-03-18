using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eevee : Pokemon
	{
		public override string Name => "Eevee";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Adaptability() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Anticipation() };
		public override Stats BaseStats => new Stats(55, 55, 50, 55, 45, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
