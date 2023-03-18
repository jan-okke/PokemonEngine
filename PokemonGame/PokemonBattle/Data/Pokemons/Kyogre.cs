using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kyogre : Pokemon
	{
		public override string Name => "Kyogre";
		public override List<Ability> AvailableAbilities => new() {new Drizzle() };
		public override Stats BaseStats => new Stats(100, 100, 90, 90, 150, 140);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
