using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gligar : Pokemon
	{
		public override string Name => "Gligar";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Immunity() };
		public override Stats BaseStats => new Stats(65, 75, 105, 85, 35, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
