using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Voltorb : Pokemon
	{
		public override string Name => "Voltorb";
		public override List<Ability> AvailableAbilities => new() {new Soundproof(), new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aftermath() };
		public override Stats BaseStats => new Stats(40, 30, 50, 100, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
