using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Charizard : Pokemon
	{
		public override string Name => "Charizard";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Solarpower() };
		public override Stats BaseStats => new Stats(78, 84, 78, 100, 109, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Flying };
