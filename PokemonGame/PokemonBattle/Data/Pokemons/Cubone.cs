using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cubone : Pokemon
	{
		public override string Name => "Cubone";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Battlearmor() };
		public override Stats BaseStats => new Stats(50, 50, 95, 35, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
