using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Buneary : Pokemon
	{
		public override string Name => "Buneary";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Limber() };
		public override Stats BaseStats => new Stats(55, 66, 44, 85, 44, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
