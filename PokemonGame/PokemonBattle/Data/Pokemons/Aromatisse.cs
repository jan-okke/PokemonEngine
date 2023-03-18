using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aromatisse : Pokemon
	{
		public override string Name => "Aromatisse";
		public override List<Ability> AvailableAbilities => new() {new Healer() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Aromaveil() };
		public override Stats BaseStats => new Stats(101, 72, 72, 29, 99, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
