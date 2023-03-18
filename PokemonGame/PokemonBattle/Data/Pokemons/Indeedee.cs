using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Indeedee : Pokemon
	{
		public override string Name => "Indeedee";
		public override List<Ability> AvailableAbilities => new() {new Innerfocus(), new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Psychicsurge() };
		public override Stats BaseStats => new Stats(60, 65, 55, 95, 105, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Normal };
