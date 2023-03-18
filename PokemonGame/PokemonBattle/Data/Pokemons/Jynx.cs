using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jynx : Pokemon
	{
		public override string Name => "Jynx";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Forewarn() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Dryskin() };
		public override Stats BaseStats => new Stats(65, 50, 35, 95, 115, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
