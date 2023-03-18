using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eternatus : Pokemon
	{
		public override string Name => "Eternatus";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(140, 85, 95, 130, 145, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
