using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vigoroth : Pokemon
	{
		public override string Name => "Vigoroth";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit() };
		public override Stats BaseStats => new Stats(80, 80, 80, 90, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
