using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meloetta : Pokemon
	{
		public override string Name => "Meloetta";
		public override List<Ability> AvailableAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(100, 77, 77, 90, 128, 128);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
