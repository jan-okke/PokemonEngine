using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Floette : Pokemon
	{
		public override string Name => "Floette";
		public override List<Ability> AvailableAbilities => new() {new Flowerveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Symbiosis() };
		public override Stats BaseStats => new Stats(54, 45, 47, 52, 75, 98);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
