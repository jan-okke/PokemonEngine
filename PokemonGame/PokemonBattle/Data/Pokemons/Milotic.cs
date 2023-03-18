using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Milotic : Pokemon
	{
		public override string Name => "Milotic";
		public override List<Ability> AvailableAbilities => new() {new Marvelscale(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cutecharm() };
		public override Stats BaseStats => new Stats(95, 60, 79, 81, 100, 125);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
