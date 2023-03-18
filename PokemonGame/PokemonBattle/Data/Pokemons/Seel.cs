using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Seel : Pokemon
	{
		public override string Name => "Seel";
		public override List<Ability> AvailableAbilities => new() {new Thickfat(), new Hydration() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Icebody() };
		public override Stats BaseStats => new Stats(65, 45, 55, 45, 45, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
