using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Marowak : Pokemon
	{
		public override string Name => "Marowak";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Battlearmor() };
		public override Stats BaseStats => new Stats(60, 80, 110, 45, 50, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
