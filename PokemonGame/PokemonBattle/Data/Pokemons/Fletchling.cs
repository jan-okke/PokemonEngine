using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Fletchling : Pokemon
	{
		public override string Name => "Fletchling";
		public override List<Ability> AvailableAbilities => new() {new Bigpecks() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Galewings() };
		public override Stats BaseStats => new Stats(45, 50, 43, 62, 40, 38);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
