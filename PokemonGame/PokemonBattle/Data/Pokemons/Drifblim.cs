using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Drifblim : Pokemon
	{
		public override string Name => "Drifblim";
		public override List<Ability> AvailableAbilities => new() {new Aftermath(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flareboost() };
		public override Stats BaseStats => new Stats(150, 80, 44, 80, 90, 54);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Flying };
