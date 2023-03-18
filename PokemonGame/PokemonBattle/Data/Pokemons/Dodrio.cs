using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dodrio : Pokemon
	{
		public override string Name => "Dodrio";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tangledfeet() };
		public override Stats BaseStats => new Stats(60, 110, 70, 110, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
