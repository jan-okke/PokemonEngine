using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zangoose : Pokemon
	{
		public override string Name => "Zangoose";
		public override List<Ability> AvailableAbilities => new() {new Immunity() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Toxicboost() };
		public override Stats BaseStats => new Stats(73, 115, 60, 90, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
