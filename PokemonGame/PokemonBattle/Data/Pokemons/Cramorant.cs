using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cramorant : Pokemon
	{
		public override string Name => "Cramorant";
		public override List<Ability> AvailableAbilities => new() {new Gulpmissile() };
		public override Stats BaseStats => new Stats(70, 85, 55, 85, 85, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Flying, PokemonType.Water };
