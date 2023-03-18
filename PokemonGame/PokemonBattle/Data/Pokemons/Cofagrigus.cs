using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cofagrigus : Pokemon
	{
		public override string Name => "Cofagrigus";
		public override List<Ability> AvailableAbilities => new() {new Mummy() };
		public override Stats BaseStats => new Stats(58, 50, 145, 30, 95, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
