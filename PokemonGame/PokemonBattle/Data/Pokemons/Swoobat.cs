using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swoobat : Pokemon
	{
		public override string Name => "Swoobat";
		public override List<Ability> AvailableAbilities => new() {new Unaware(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Simple() };
		public override Stats BaseStats => new Stats(67, 57, 55, 114, 77, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
