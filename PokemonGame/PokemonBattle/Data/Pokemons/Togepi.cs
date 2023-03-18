using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Togepi : Pokemon
	{
		public override string Name => "Togepi";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Superluck() };
		public override Stats BaseStats => new Stats(35, 20, 65, 20, 40, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
