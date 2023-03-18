using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ditto : Pokemon
	{
		public override string Name => "Ditto";
		public override List<Ability> AvailableAbilities => new() {new Limber() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Imposter() };
		public override Stats BaseStats => new Stats(48, 48, 48, 48, 48, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
