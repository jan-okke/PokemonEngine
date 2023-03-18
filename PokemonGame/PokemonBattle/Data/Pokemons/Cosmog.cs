using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cosmog : Pokemon
	{
		public override string Name => "Cosmog";
		public override List<Ability> AvailableAbilities => new() {new Unaware() };
		public override Stats BaseStats => new Stats(43, 29, 31, 37, 29, 31);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
