using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Morpeko : Pokemon
	{
		public override string Name => "Morpeko";
		public override List<Ability> AvailableAbilities => new() {new Hungerswitch() };
		public override Stats BaseStats => new Stats(58, 95, 58, 97, 70, 58);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric, PokemonType.Dark };
