using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lunala : Pokemon
	{
		public override string Name => "Lunala";
		public override List<Ability> AvailableAbilities => new() {new Shadowshield() };
		public override Stats BaseStats => new Stats(137, 113, 89, 97, 137, 107);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
