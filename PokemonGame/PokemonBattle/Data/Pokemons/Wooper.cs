using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wooper : Pokemon
	{
		public override string Name => "Wooper";
		public override List<Ability> AvailableAbilities => new() {new Damp(), new Waterabsorb() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(55, 45, 45, 15, 25, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ground };
