using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Electivire : Pokemon
	{
		public override string Name => "Electivire";
		public override List<Ability> AvailableAbilities => new() {new Motordrive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(75, 123, 67, 95, 95, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
