using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Delibird : Pokemon
	{
		public override string Name => "Delibird";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit(), new Hustle() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Insomnia() };
		public override Stats BaseStats => new Stats(45, 55, 45, 75, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Flying };
