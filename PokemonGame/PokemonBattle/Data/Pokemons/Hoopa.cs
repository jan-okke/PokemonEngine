using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hoopa : Pokemon
	{
		public override string Name => "Hoopa";
		public override List<Ability> AvailableAbilities => new() {new Magician() };
		public override Stats BaseStats => new Stats(80, 110, 60, 70, 150, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Ghost };
