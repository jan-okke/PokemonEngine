using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Clauncher : Pokemon
	{
		public override string Name => "Clauncher";
		public override List<Ability> AvailableAbilities => new() {new Megalauncher() };
		public override Stats BaseStats => new Stats(50, 53, 62, 44, 58, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
