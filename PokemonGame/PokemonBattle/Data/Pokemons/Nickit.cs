using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nickit : Pokemon
	{
		public override string Name => "Nickit";
		public override List<Ability> AvailableAbilities => new() {new Runaway(), new Unburden() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stakeout() };
		public override Stats BaseStats => new Stats(40, 28, 28, 50, 47, 52);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
