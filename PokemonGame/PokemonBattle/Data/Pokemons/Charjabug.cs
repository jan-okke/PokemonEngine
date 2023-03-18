using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Charjabug : Pokemon
	{
		public override string Name => "Charjabug";
		public override List<Ability> AvailableAbilities => new() {new Battery() };
		public override Stats BaseStats => new Stats(57, 82, 95, 36, 55, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Electric };
