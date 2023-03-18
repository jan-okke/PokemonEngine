using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sawsbuck : Pokemon
	{
		public override string Name => "Sawsbuck";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(80, 100, 70, 95, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
