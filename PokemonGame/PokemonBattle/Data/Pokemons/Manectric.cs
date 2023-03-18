using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Manectric : Pokemon
	{
		public override string Name => "Manectric";
		public override List<Ability> AvailableAbilities => new() {new Static(), new Lightningrod() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Minus() };
		public override Stats BaseStats => new Stats(70, 75, 60, 105, 105, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
