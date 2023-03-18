using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golurk : Pokemon
	{
		public override string Name => "Golurk";
		public override List<Ability> AvailableAbilities => new() {new Ironfist(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(89, 124, 80, 55, 55, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Ghost };
