using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bruxish : Pokemon
	{
		public override string Name => "Bruxish";
		public override List<Ability> AvailableAbilities => new() {new Dazzling(), new Strongjaw() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Wonderskin() };
		public override Stats BaseStats => new Stats(68, 105, 70, 92, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
