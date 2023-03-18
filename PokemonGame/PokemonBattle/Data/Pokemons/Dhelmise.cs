using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dhelmise : Pokemon
	{
		public override string Name => "Dhelmise";
		public override List<Ability> AvailableAbilities => new() {new Steelworker() };
		public override Stats BaseStats => new Stats(70, 131, 100, 40, 86, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
