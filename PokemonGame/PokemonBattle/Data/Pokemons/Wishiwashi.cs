using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wishiwashi : Pokemon
	{
		public override string Name => "Wishiwashi";
		public override List<Ability> AvailableAbilities => new() {new Schooling() };
		public override Stats BaseStats => new Stats(45, 20, 20, 40, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Water };
