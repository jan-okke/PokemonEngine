using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Audino : Pokemon
	{
		public override string Name => "Audino";
		public override List<Ability> AvailableAbilities => new() {new Healer(), new Regenerator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Klutz() };
		public override Stats BaseStats => new Stats(103, 60, 86, 50, 60, 86);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
