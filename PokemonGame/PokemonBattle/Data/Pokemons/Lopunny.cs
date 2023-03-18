using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lopunny : Pokemon
	{
		public override string Name => "Lopunny";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Limber() };
		public override Stats BaseStats => new Stats(65, 76, 84, 105, 54, 96);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
