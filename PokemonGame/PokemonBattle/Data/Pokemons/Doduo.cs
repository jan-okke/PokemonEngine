using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Doduo : Pokemon
	{
		public override string Name => "Doduo";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Tangledfeet() };
		public override Stats BaseStats => new Stats(35, 85, 45, 75, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
