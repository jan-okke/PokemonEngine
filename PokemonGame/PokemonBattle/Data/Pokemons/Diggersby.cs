using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Diggersby : Pokemon
	{
		public override string Name => "Diggersby";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hugepower() };
		public override Stats BaseStats => new Stats(85, 56, 77, 78, 50, 77);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Ground };
