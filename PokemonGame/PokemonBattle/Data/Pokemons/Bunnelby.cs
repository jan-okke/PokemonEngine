using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bunnelby : Pokemon
	{
		public override string Name => "Bunnelby";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Cheekpouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hugepower() };
		public override Stats BaseStats => new Stats(38, 36, 38, 57, 32, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
