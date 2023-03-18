using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drifloon : Pokemon
	{
		public override string Name => "Drifloon";
		public override List<Ability> AvailableAbilities => new() {new Aftermath(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flareboost() };
		public override Stats BaseStats => new Stats(90, 50, 34, 70, 60, 44);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
