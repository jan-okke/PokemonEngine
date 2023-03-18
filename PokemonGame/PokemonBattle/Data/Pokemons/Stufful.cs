using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stufful : Pokemon
	{
		public override string Name => "Stufful";
		public override List<Ability> AvailableAbilities => new() {new Fluffy(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cutecharm() };
		public override Stats BaseStats => new Stats(70, 75, 50, 50, 45, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fighting };
