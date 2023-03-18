using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gogoat : Pokemon
	{
		public override string Name => "Gogoat";
		public override List<Ability> AvailableAbilities => new() {new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Grasspelt() };
		public override Stats BaseStats => new Stats(123, 100, 62, 68, 97, 81);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
