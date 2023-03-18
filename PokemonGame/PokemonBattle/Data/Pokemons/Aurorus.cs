using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aurorus : Pokemon
	{
		public override string Name => "Aurorus";
		public override List<Ability> AvailableAbilities => new() {new Refrigerate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Snowwarning() };
		public override Stats BaseStats => new Stats(123, 77, 72, 58, 99, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Ice };
