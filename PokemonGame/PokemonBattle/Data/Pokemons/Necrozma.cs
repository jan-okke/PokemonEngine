using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Necrozma : Pokemon
	{
		public override string Name => "Necrozma";
		public override List<Ability> AvailableAbilities => new() {new Prismarmor() };
		public override Stats BaseStats => new Stats(97, 107, 101, 79, 127, 89);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
