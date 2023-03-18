using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gliscor : Pokemon
	{
		public override string Name => "Gliscor";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisonheal() };
		public override Stats BaseStats => new Stats(75, 95, 125, 95, 45, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
